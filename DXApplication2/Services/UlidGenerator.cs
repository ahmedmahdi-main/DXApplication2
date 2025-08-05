using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// ReSharper disable MemberCanBePrivate.Global

namespace DXApplication2.Services
{
    public static partial class UlidGenerator
    {
        // Constants and Static Fields
        private static readonly char[] Base32Chars =
            "0123456789ABCDEFGHJKMNPQRSTVWXYZ".ToCharArray();

        private static readonly RandomNumberGenerator RandomGenerator =
            RandomNumberGenerator.Create();

        // private static readonly Regex UlidRegex = MyRegex();

        private static readonly Dictionary<char, int> Base32Lookup = Base32Chars
            .Select((c, i) => new { c, i })
            .ToDictionary(x => x.c, x => x.i);

        private static readonly byte InstanceIdentifier =
            (byte)(Environment.MachineName.GetHashCode() & 0xFF);

        // ==================================================
        // Public Methods
        // ==================================================

        public static string GenerateUlid(bool withHyphens = true)
        {
            var timestampBytes = GetTimestampBytes(DateTimeOffset.UtcNow);
            var randomBytes = GetEnhancedRandomBytes();
            var combinedBytes = CombineBytes(timestampBytes, randomBytes);
            var ulid = EncodeToBase32(combinedBytes);
            return withHyphens ? InsertHyphens(ulid) : ulid;
        }

        public static string GenerateUlidWithServiceId(int serviceId, bool withHyphens = true)
        {
            if (serviceId is < 0 or > 1_048_575)
                throw new ArgumentOutOfRangeException(nameof(serviceId),
                    "Service ID must be between 0 and 1,048,575.");

            var ulid = GenerateUlid(withHyphens: false);
            var serviceIdPrefix = EncodeServiceIdToBase32(serviceId, 4);
            var combinedUlid = serviceIdPrefix + ulid;

            return withHyphens ? InsertHyphens(combinedUlid) : combinedUlid;
        }

        public static IEnumerable<string> ParallelGenerateBatchUlids(int count, int serviceId,
            bool withHyphens = true)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count),
                    "Count must be greater than zero.");

            if (serviceId is < 0 or > 1_048_575)
                throw new ArgumentOutOfRangeException(nameof(serviceId),
                    "Service ID must be between 0 and 1,048,575.");

            var ulids = new string[count];
            var serviceIdPrefix = EncodeServiceIdToBase32(serviceId, 4);

            Parallel.For(0, count,
                new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
                () => new byte[10],
                (i, state, randomBytes) =>
                {
                    var timestampBytes = GetTimestampBytes(DateTimeOffset.UtcNow);
                    RandomGenerator.GetBytes(randomBytes);
                    var combinedBytes = CombineBytes(timestampBytes, randomBytes);
                    var ulid = EncodeToBase32(combinedBytes);
                    ulids[i] = withHyphens
                        ? InsertHyphens(serviceIdPrefix + ulid)
                        : serviceIdPrefix + ulid;
                    return randomBytes;
                },
                _ => { });

            return ulids;
        }

        // public static IEnumerable<string> GenerateBatchUlids(int count, bool withHyphens = true)
        // {
        //     if (count <= 0)
        //         throw new ArgumentOutOfRangeException(nameof(count),
        //             "Count must be greater than zero.");
        //
        //     var ulids = new string[count];
        //
        //     Parallel.For(0, count, i =>
        //     {
        //         var timestampBytes = GetTimestampBytes(DateTimeOffset.UtcNow);
        //         var randomBytes = GetEnhancedRandomBytes();
        //         var combinedBytes = CombineBytes(timestampBytes, randomBytes);
        //         var ulid = EncodeToBase32(combinedBytes);
        //         ulids[i] = withHyphens ? InsertHyphens(ulid) : ulid;
        //     });
        //
        //     return ulids;
        // }

        public static string Parse(string ulid)
        {
            if (!TryParse(ulid, out var parsedUlid))
                throw new ArgumentException("The provided ULID is not valid.", nameof(ulid));
            if (parsedUlid is null)
                throw new ArgumentNullException(nameof(parsedUlid));
            return parsedUlid;
        }

        public static bool TryParse(string ulid, out string? parsedUlid)
        {
            ArgumentNullException.ThrowIfNull(ulid);
            parsedUlid = null;
            if (string.IsNullOrEmpty(ulid))
                return false;

            ulid = ulid.Replace("-", "");
            if (!UlidRegex.IsMatch(ulid))
                return false;

            parsedUlid = InsertHyphens(ulid);
            return true;
        }

        public static bool IsValidUlid(string ulid) => TryParse(ulid, out _);

        public static int ExtractServiceIdFromUlid(string ulid)
        {
            if (ulid.Length < 30)
                throw new ArgumentException("Invalid ULID format.", nameof(ulid));

            ulid = ulid.Replace("-", "");
            var serviceIdPrefix = ulid[..4];
            return DecodeServiceIdFromBase32(serviceIdPrefix);
        }

        public static IEnumerable<string> GenerateUlids(int count, int serviceId) =>
            ParallelGenerateBatchUlids(count, serviceId: serviceId);

        public static IEnumerable<string> GenerateUlidsForCollection<T>(IEnumerable<T> collection,
            bool withHyphens = true) =>
            collection.Select(_ => GenerateUlid(withHyphens));

        public static bool TryParseUlid(string ulid, out string? parsedUlid) =>
            TryParse(ulid, out parsedUlid);

        public static IEnumerable<string> GenerateServiceUlids<T>(IEnumerable<T> collection,
            int serviceId, bool withHyphens = true) =>
            collection.Select(_ => GenerateUlidWithServiceId(serviceId, withHyphens));

        public static string FormatUlid(string ulid, bool withHyphens) =>
            withHyphens ? InsertHyphens(ulid) : ulid.Replace("-", "");

        public static string ParseUlid(string ulid) => Parse(ulid);

        public static IEnumerable<string> GenerateUlidsWithProgress(int count,
            bool withHyphens = true, Action<int>? progressCallback = null)
        {
            var ulids = new string[count];
            for (var i = 0; i < count; i++)
            {
                ulids[i] = GenerateUlid(withHyphens);
                progressCallback?.Invoke(i + 1);
            }

            return ulids;
        }

        // ==================================================
        // Private Methods
        // ==================================================

        private static string EncodeServiceIdToBase32(int serviceId, int length)
        {
            var encoded = new StringBuilder();
            while (serviceId > 0)
            {
                var index = serviceId & 31;
                encoded.Insert(0, Base32Chars[index]);
                serviceId >>= 5;
            }

            return encoded.ToString().PadLeft(length, '0');
        }

        private static int DecodeServiceIdFromBase32(string serviceIdPrefix)
        {
            return serviceIdPrefix.Aggregate(0, (acc, c) =>
            {
                if (!Base32Lookup.TryGetValue(c, out var value))
                    throw new FormatException($"Invalid Base32 character '{c}'.");
                return (acc << 5) + value;
            });
        }

        private static byte[] GetTimestampBytes(DateTimeOffset timestamp)
        {
            var timestampNano = timestamp.ToUnixTimeMilliseconds() * 1_000_000L;
            var timestampBytes = BitConverter.GetBytes(timestampNano);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(timestampBytes);
            var truncated = new byte[6];
            Array.Copy(timestampBytes, 2, truncated, 0, 6);
            return truncated;
        }

        private static byte[] GetEnhancedRandomBytes()
        {
            var randomBytes = new byte[10];
            RandomGenerator.GetBytes(randomBytes);
            randomBytes[0] ^= InstanceIdentifier;
            return randomBytes;
        }

        private static byte[] CombineBytes(byte[] timestampBytes, byte[] randomBytes)
        {
            var combinedBytes = new byte[16];
            Array.Copy(timestampBytes, combinedBytes, 6);
            Array.Copy(randomBytes, 0, combinedBytes, 6, 10);
            return combinedBytes;
        }

        private static string EncodeToBase32(byte[] data)
        {
            var result = new StringBuilder(26);
            for (var i = 0; i < data.Length; i += 5)
            {
                ulong chunk = 0;
                var chunkSize = Math.Min(5, data.Length - i);
                for (var j = 0; j < chunkSize; j++)
                    chunk = (chunk << 8) | data[i + j];
                for (var j = 0; j < (chunkSize * 8 + 4) / 5; j++)
                {
                    result.Append(Base32Chars[(int)(chunk & 31)]);
                    chunk >>= 5;
                }
            }

            return result.ToString();
        }

        private static string InsertHyphens(string ulid)
        {
            ulid = ulid.PadLeft(30, '0');
            return ulid.Length switch
            {
                26 =>
                    $"{ulid[..6]}-{ulid.Substring(6, 8)}-{ulid.Substring(14, 8)}-{ulid.Substring(22, 4)}",
                30 =>
                    $"{ulid[..4]}-{ulid.Substring(4, 6)}-{ulid.Substring(10, 8)}-{ulid.Substring(18, 8)}-{ulid.Substring(26, 4)}",
                _ => throw new ArgumentException(
                    $"ULID must be 26 or 30 characters long, but got {ulid.Length}.")
            };
        }

        private static long Base32ToLong(string base32)
        {
            return base32.Aggregate(0L, (current, c) =>
            {
                if (!Base32Lookup.TryGetValue(c, out var value))
                    throw new FormatException($"Invalid Base32 character '{c}'.");
                return (current << 5) + value;
            });
        }

        private static byte[] DecodeBase32ToBytes(string base32)
        {
            var output = new List<byte>();
            int buffer = 0, bitsLeft = 0;

            foreach (var c in base32)
            {
                if (!Base32Lookup.TryGetValue(c, out var value))
                    throw new FormatException($"Invalid Base32 character '{c}'.");

                buffer = (buffer << 5) | value;
                bitsLeft += 5;

                if (bitsLeft < 8) continue;
                bitsLeft -= 8;
                output.Add((byte)((buffer >> bitsLeft) & 0xFF));
            }

            return output.ToArray();
        }

        private static readonly Regex UlidRegex = new("^[0123456789ABCDEFGHJKMNPQRSTVWXYZ]{26}$",
            RegexOptions.Compiled);

    }
}