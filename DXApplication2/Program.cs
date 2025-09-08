using DXApplication2.Forms;
using DXApplication2.Data;
using DXApplication2.DataAccess;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the main form
            var mainForm = new MainForm();
            
            // Initialize seed data in background after form is created
            _ = Task.Run(async () => await InitializeSeedDataAsync());

            Application.Run(mainForm);
        }

        /// <summary>
        /// Initialize seed data if needed - runs in background
        /// </summary>
        private static async Task InitializeSeedDataAsync()
        {
            try
            {
                Console.WriteLine("Starting seed data initialization...");
                
                var seedData = new SeedData();
                using var unitOfWork = new UnitOfWork();
                await seedData.SeedEmployeesAsync(unitOfWork);
                
                Console.WriteLine("Seed data initialization completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: Failed to initialize seed data: {ex.Message}");
                Console.WriteLine("Application will continue to function normally.");
            }
        }
    }
}
