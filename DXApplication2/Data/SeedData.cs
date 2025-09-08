using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DXApplication2.DataAccess;
using DXApplication2.Entities;

namespace DXApplication2.Data;

public class SeedData
{
    private readonly string CSIT_EmployeesNamesAsJson = """
[
  {
    "NationalId": 117625332,
    "Name": "احمد ستار جابر عيدان الطائي",
    "Department": "الحوكمة الالكترونية",
    "Position": "مسوؤل شعبة تكنولوجيا المعلومات",
    "Phone": 7800168889
  },
  {
    "NationalId": 155324194,
    "Name": "احمد سوادي خضير عبود الدعمي",
    "Department": "شعبة الدراسات والتخطيط",
    "Position": "مسوول وحدة البيانات",
    "Phone": 7712868186
  },
  {
    "NationalId": 117629590,
    "Name": "احمد صالح غافل محمد التميمي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول وحدة اكاديمية السيسكو",
    "Phone": 7801784040
  },
  {
    "NationalId": 154256715,
    "Name": "احمد علي كريم عبد العباس",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7732757915
  },
  {
    "NationalId": 117629938,
    "Name": "احمد فائق عبد المجيد يوسف",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول وحدة التعليم الالكتروني",
    "Phone": 7902535894
  },
  {
    "NationalId": 151113778,
    "Name": "احمد مهدي عناد حسون خزعلي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7806336393
  },
  {
    "NationalId": 117623716,
    "Name": "ارشد كامل محمد عباس الربيعي",
    "Department": "شعبة الاعلام والاتصال الحكومي",
    "Position": null,
    "Phone": 7802252432
  },
  {
    "NationalId": 151074305,
    "Name": "ازهار حميد مهدي احمد الشهرستاني",
    "Department": "شعبة الشؤون القانونية",
    "Position": null,
    "Phone": 7732303265
  },
  {
    "NationalId": 117633111,
    "Name": "ازهار علي عباس صالح المرشدي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7811102872
  },
  {
    "NationalId": 117647675,
    "Name": "ازهى طلال محمد علي قاسم الجلجاوي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7723763375
  },
  {
    "NationalId": 148810121,
    "Name": "اسراء صبري فخري حسون الغانمي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7706007878
  },
  {
    "NationalId": 1,
    "Name": "اسراء صمد دويح عبد الصاحب الصافي",
    "Department": "قسم تكنولوجيا المعلومات",
    "Position": null,
    "Phone": 7711649780
  },
  {
    "NationalId": 141806495,
    "Name": "اسراء عبد الحسين عبد الامير صادق الجميلي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7812764151
  },
  {
    "NationalId": 118069021,
    "Name": "اسراء نجم عبد الله مهدي الانباري",
    "Department": "امانة مجلس الكلية",
    "Position": null,
    "Phone": 7700866027
  },
  {
    "NationalId": 117628964,
    "Name": "اسيا مهدي ناصر حسين الزبيدي",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة الترقيات العلمية",
    "Phone": 7725965208
  },
  {
    "NationalId": 117628948,
    "Name": "اشوان انور عبد المنعم علي العلي",
    "Department": "علوم الحاسوب",
    "Position": "مسوول شعبة ضمان الجودة والأداء الجامعي",
    "Phone": 7711912402
  },
  {
    "NationalId": 148817940,
    "Name": "افراح عمران موسى هدهود الربيعي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7819955137
  },
  {
    "NationalId": 151121627,
    "Name": "الاء حسين محي عبود الخالدي",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": 7711301614
  },
  {
    "NationalId": 117629181,
    "Name": "الهام محمد ثابت عبد الامير السعدي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول وحدة النشاطات الفنية والثقافية",
    "Phone": 7818202244
  },
  {
    "NationalId": 155324152,
    "Name": "انعام رزاق عبد المحسن صكر ال ضيدان",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7876101788
  },
  {
    "NationalId": 117628980,
    "Name": "انعام هادي عبد يوسف العبد الله",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7701857383
  },
  {
    "NationalId": 117646870,
    "Name": "انغام عادل جياد حسين السعيدي",
    "Department": "علوم الحاسوب",
    "Position": "مسوول شعبة المكتبة",
    "Phone": 7731459499
  },
  {
    "NationalId": 117629615,
    "Name": "اياد حميد موسى جدوع الكطراني",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7712749147
  },
  {
    "NationalId": 143829809,
    "Name": "ايلاف عادل عباس عيسى الهاشمي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7734319334
  },
  {
    "NationalId": 117637311,
    "Name": "ايمان صلاح ناصر حسين الخطيب",
    "Department": "شعبة الخدمات",
    "Position": "مسؤول وحدة الاعمار والمشاريع",
    "Phone": 7735308071
  },
  {
    "NationalId": 117629897,
    "Name": "ايناس رؤوف عبد الرسول محمد شريف",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7801330273
  },
  {
    "NationalId": 151114490,
    "Name": "بدور علاء محمود موسى الهاشمي",
    "Department": "الحوكمة الالكترونية",
    "Position": "مسؤؤل وحدة الحوكمة الالكترونية",
    "Phone": 7838071707
  },
  {
    "NationalId": 116124377,
    "Name": "بهيجه خضير شكر حلو الغانمي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7707119954
  },
  {
    "NationalId": 117597424,
    "Name": "بيداء فاضل ظاهر حسين الزيدي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7767968419
  },
  {
    "NationalId": 155324107,
    "Name": "تبارك علي شوكت نعمه الجبوري",
    "Department": "وحدة الشؤون العلمية",
    "Position": null,
    "Phone": 7703942125
  },
  {
    "NationalId": 117629813,
    "Name": "حسام حسن كاظم جواد بريطم",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7732972302
  },
  {
    "NationalId": 155324037,
    "Name": "حسن حقي عبد علي عبد الله العنيسي",
    "Department": "وحدة شوؤن المواطنين",
    "Position": "مسوول وحدة شوؤن المواطنين",
    "Phone": 7835035638
  },
  {
    "NationalId": 154522137,
    "Name": "حسن عامر عبد الحسين عبد الوهاب",
    "Department": "شعبة الموارد البشرية",
    "Position": null,
    "Phone": 7800161115
  },
  {
    "NationalId": 117631850,
    "Name": "حسنين عبد الحسين مهدي جعفر الخفاجي",
    "Department": "الشعبة القانونية",
    "Position": "مسؤول شعبة الشؤون القانونية",
    "Phone": 7808232828
  },
  {
    "NationalId": 151111941,
    "Name": "حسين زكي جاسم محمد المنكوشي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7804521055
  },
  {
    "NationalId": 151111967,
    "Name": "حسين صالح مهدي جبر المجلي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7723792466
  },
  {
    "NationalId": 148812099,
    "Name": "حسين علي حسين علي محمد الاسدي",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": 7735302377
  },
  {
    "NationalId": 150934138,
    "Name": "حمد ناصر ثامر خليف اليساري",
    "Department": "وحدة التجهيزات",
    "Position": "مسؤول وحدة التجهيزات",
    "Phone": 7751752252
  },
  {
    "NationalId": 117625709,
    "Name": "حنان خضير شرشاب علي الغزي",
    "Department": "الشعبة الإدارية",
    "Position": null,
    "Phone": 7827051458
  },
  {
    "NationalId": 151112225,
    "Name": "حوراء رزاق عبد الامير حسين الكريطي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7702751489
  },
  {
    "NationalId": 117626885,
    "Name": "حوراء فرحان محمد جواد علي افند",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7723120531
  },
  {
    "NationalId": 117623097,
    "Name": "حيدر خضير مراد لفته اليساري",
    "Department": "وحدة الترقيات العلمية",
    "Position": null,
    "Phone": 7706024110
  },
  {
    "NationalId": 117629420,
    "Name": "حيدر عبد الامير مرهون عبود الخفاجي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7711914662
  },
  {
    "NationalId": 151042906,
    "Name": "حيدر محمد علي علي كاظم الغانمي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7740811806
  },
  {
    "NationalId": 148813513,
    "Name": "دعاء عباس رشيد جاسم الطرفي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "التصاريح الأمنية",
    "Phone": 7736708445
  },
  {
    "NationalId": 148818013,
    "Name": "دنيا جاسم محمد مصطفى الحسني",
    "Department": "شعبة الدراسات والتخطيط",
    "Position": "مسؤول شعبة الدراسات والتخطيط\nمسؤول وحدة الاحصاء",
    "Phone": 7816379441
  },
  {
    "NationalId": 151112704,
    "Name": "رؤى عبد الجواد لفته كاظم المجلي",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة تمكين المراة",
    "Phone": 7734635021
  },
  {
    "NationalId": 117629967,
    "Name": "رؤى عبد الرضا سعيد عبد السياح",
    "Department": "تكنلوجيا المعلومات",
    "Position": "م.و. اعتماد المختبرات",
    "Phone": 7802123356
  },
  {
    "NationalId": 148817966,
    "Name": "رسل كاظم ناصر لفته الطوفان",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7726248605
  },
  {
    "NationalId": 155324178,
    "Name": "رسل منصور عبد الحسن حسون العامري",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7802487417
  },
  {
    "NationalId": 154256744,
    "Name": "رفل خضير عباس نصيف الزبيدي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7725084902
  },
  {
    "NationalId": 150913393,
    "Name": "رند عبد الكريم حسن جاسم",
    "Department": "شعبة الخدمات",
    "Position": "مسؤول الوحدة الزراعية",
    "Phone": 7826071306
  },
  {
    "NationalId": 117630071,
    "Name": "رند عبد الواحد محمد علي محمد البير",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة التعليم المستمر",
    "Phone": 7705790388
  },
  {
    "NationalId": 151035977,
    "Name": "رواء علي عبد زيد عصواد",
    "Department": "وحدة الاعمار والمشاريع",
    "Position": null,
    "Phone": 7723867760
  },
  {
    "NationalId": 117631777,
    "Name": "رونق عبد عون ناصر كريم اشعيب",
    "Department": "وحدة الاعمار والمشاريع",
    "Position": null,
    "Phone": 7714903459
  },
  {
    "NationalId": 154256757,
    "Name": "زهراء سامي عبد الامير علي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7806650657
  },
  {
    "NationalId": 151112762,
    "Name": "زهراء سمير جواد حبيب الموسوي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7705879727
  },
  {
    "NationalId": 151112832,
    "Name": "زهراء عبد الامير احمد علوان الخفاجي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول وحدة التدريب الصيفي",
    "Phone": 7801425913
  },
  {
    "NationalId": 148817995,
    "Name": "زهراء عبد حرجان غايب ال حسين",
    "Department": "وحدة امانة مجلس الكلية",
    "Position": "البرنامج الحكومي /مسؤول وحدة الموقع الالكتروني",
    "Phone": 7713166582
  },
  {
    "NationalId": 117626322,
    "Name": "زهراء كاظم محمد اسماعيل السندي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7711711482
  },
  {
    "NationalId": 117630055,
    "Name": "زهراء نجم عبد الله مهدي عبد الانباري",
    "Department": "علوم الحاسوب",
    "Position": "امين مجلس الكلية",
    "Phone": 7706004391
  },
  {
    "NationalId": 117629462,
    "Name": "زيد حسن علي عبود نصر الله",
    "Department": "تكنلوجيا المعلومات",
    "Position": "رئيس قسم تكنلوجيا المعلومات",
    "Phone": 7733331182
  },
  {
    "NationalId": 154256760,
    "Name": "زينب علي وحيد حسن",
    "Department": "الشعبة الإدارية",
    "Position": null,
    "Phone": 7730032280
  },
  {
    "NationalId": 151112957,
    "Name": "زينب فاضل حسين السلطاني",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7811566241
  },
  {
    "NationalId": 148817924,
    "Name": "زينه احمد كاظم عبد الزيدي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7724097269
  },
  {
    "NationalId": 117630000,
    "Name": "زينه عبد الرضا عبد الرزاق عبد الوهاب ابو طحين",
    "Department": "علوم الحاسوب",
    "Position": "مسوول شعبة الدراسات العليا",
    "Phone": 7806877826
  },
  {
    "NationalId": 117628807,
    "Name": "زينه محمد حسن محمد علي ابو المعالي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7737632030
  },
  {
    "NationalId": 151113004,
    "Name": "ساره جبار يعقوب الخويلدي",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة الرواتب",
    "Phone": 7803562472
  },
  {
    "NationalId": 151439744,
    "Name": "سجى نعيم تركي عبيد المنصوري",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7832512037
  },
  {
    "NationalId": 148813810,
    "Name": "سليمه مرواح عيسى مطر",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7833518959
  },
  {
    "NationalId": 2,
    "Name": "سمر فرحان عبد الله يوسف الهاشمي",
    "Department": "شعبة الدراسات العليا",
    "Position": null,
    "Phone": 7714903254
  },
  {
    "NationalId": 117623039,
    "Name": "سناء محسن شاكر زاهي العبودي",
    "Department": "شعبة شؤون الطلبة و التسجيل",
    "Position": null,
    "Phone": 7818001050
  },
  {
    "NationalId": 117629459,
    "Name": "سهير نوري علوان حمد البياتي",
    "Department": "علوم الحاسوب",
    "Position": "مقرر الدراسات العليا",
    "Phone": 7831719490
  },
  {
    "NationalId": 117629529,
    "Name": "سيف علي عبد جبار ال لطيف",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول شعبة الموقع الالكتروني/رئاسة الجامعة",
    "Phone": 7706229797
  },
  {
    "NationalId": 117624706,
    "Name": "شايع ماجد راضي عبيد البرياوي",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": "مسؤول شعبة الشؤون المالية",
    "Phone": 7801122483
  },
  {
    "NationalId": 148814615,
    "Name": "شفاء حمزه عبد الله سهر الطائي",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": null,
    "Phone": 7714878981
  },
  {
    "NationalId": 117622490,
    "Name": "شميم عبد الرضا سعيد عبد السباح",
    "Department": "وحدة شوون العلمية",
    "Position": null,
    "Phone": 7811110400
  },
  {
    "NationalId": 148810019,
    "Name": "شهد رؤوف محمد عبد الامير المالكي",
    "Department": "شعبة الخدمات",
    "Position": "مسؤول وحدة الصيانة والخدمات",
    "Phone": 7722889057
  },
  {
    "NationalId": 117636954,
    "Name": "شيماء هادي مزعل فيحان حسناوي",
    "Department": "وحدة التقاعد",
    "Position": "مسؤول وحدة شؤون الموظفين",
    "Phone": 7725415391
  },
  {
    "NationalId": 151113570,
    "Name": "صابرين هاشم جاسم احمد الساده",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسوؤل وحدة التسجيل والقبول",
    "Phone": 7736089162
  },
  {
    "NationalId": 151113608,
    "Name": "صاحب كريم صاحب عبود الخاقاني",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7706002986
  },
  {
    "NationalId": 101135186,
    "Name": "صبا علاء حسون شاهين العبايجي",
    "Department": "علوم الحاسوب",
    "Position": "مسوول وحدة حقوق الانسان",
    "Phone": 7839594817
  },
  {
    "NationalId": 117630310,
    "Name": "صباح مهدي حسين عبد علي العبد علي",
    "Department": "شعبة الموارد البشرية",
    "Position": "مسؤول شعبة الموارد البشرية",
    "Phone": 7724694365
  },
  {
    "NationalId": 151113682,
    "Name": "ضياء عدنان صاحب عبد الزهره الخطيب",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7732219446
  },
  {
    "NationalId": 117623310,
    "Name": "طلبه مانع حمادي موسى الكصراوي",
    "Department": "وحدة الملفات",
    "Position": "مسؤول وحدة الملفات والتوثيق الالكتروني",
    "Phone": 7760179037
  },
  {
    "NationalId": 150028345,
    "Name": "عامره حمود حساني العكيلي",
    "Department": "وحدة تمكين المرأة",
    "Position": null,
    "Phone": 7732403267
  },
  {
    "NationalId": 117629446,
    "Name": "عصام حامد عباس حسن ال محمد",
    "Department": "معاون العميد الإداري",
    "Position": "معاون العميد للشؤون الإدارية والمالية",
    "Phone": 7724689116
  },
  {
    "NationalId": 117629826,
    "Name": "عقيل عبد الكريم فرحان جليل السقاء",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7735317240
  },
  {
    "NationalId": 117628500,
    "Name": "علاء سلمان حسن حسين الموجد",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": 7714913497
  },
  {
    "NationalId": 151043095,
    "Name": "علاء عباس خضير سلمان",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": null
  },
  {
    "NationalId": 148817979,
    "Name": "علي حسن جاسم نوح",
    "Department": "شعبة شؤون الطلبة و التسجيل",
    "Position": "مسؤول وحدة تدقيق الملفات",
    "Phone": 7709799529
  },
  {
    "NationalId": 117629066,
    "Name": "علي رضا حسون محمد الخياط الموسوي",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول شعبة تكنلوجيا المعلومات",
    "Phone": 7712371333
  },
  {
    "NationalId": 117630224,
    "Name": "علي محمد رضا كامل النصراوي",
    "Department": "الحوكمة الالكترونية",
    "Position": "مقرر قسم تكنلوجيا المعلومات",
    "Phone": 7807344443
  },
  {
    "NationalId": 151114205,
    "Name": "علي محمد شنون يعقوب الكريم",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7815893389
  },
  {
    "NationalId": 148816880,
    "Name": "عمشه حسين محمد عجه الجبوري",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": 7807351940
  },
  {
    "NationalId": 117623125,
    "Name": "غسان جاسم عاصي زايد الموسوي",
    "Department": "مكتب العميد",
    "Position": null,
    "Phone": 7724901780
  },
  {
    "NationalId": 177595006,
    "Name": "غصون كريم مناحي فجر الصريفي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مقرر قسم تكنلوجيا المعلومات",
    "Phone": 7807344443
  },
  {
    "NationalId": 141275439,
    "Name": "غفران وسام جاسم محمد العذاري",
    "Department": "شعبة التعليم المستمر",
    "Position": null,
    "Phone": 7735380528
  },
  {
    "NationalId": 117649415,
    "Name": "فؤاد نجاح جواد كاظم الشروفي",
    "Department": "شعبة الدراسات والتخطيط",
    "Position": null,
    "Phone": 7809859645
  },
  {
    "NationalId": 151114432,
    "Name": "فاضل عباس صباح الكريطي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7708790286
  },
  {
    "NationalId": 117630534,
    "Name": "فاطمه جبار رفيش سرحان الغزي",
    "Department": "شعبة شؤون الموظفين",
    "Position": null,
    "Phone": 7725255628
  },
  {
    "NationalId": 155324149,
    "Name": "فاطمه رائد رحمان عدنان ال جوده",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7800320306
  },
  {
    "NationalId": 155324136,
    "Name": "فاطمه ضياء ناجي رشيد البغدادي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7719119579
  },
  {
    "NationalId": 117625712,
    "Name": "فاطمه عباس حسين عبد الغفور ال طعمه",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7837854360
  },
  {
    "NationalId": 117639515,
    "Name": "فاطمه عويد جاسم علي المسعودي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7807696496
  },
  {
    "NationalId": 117640281,
    "Name": "فتاه عبد الحسين خضر عبود الشمري",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": 7809768237
  },
  {
    "NationalId": 102138216,
    "Name": "فيصل سالم عبيد وزير",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": "مسؤول وحدة صندوق التعليم العالي",
    "Phone": 7718237644
  },
  {
    "NationalId": 117647451,
    "Name": "قحطان عدنان مخيف عبد المسعودي",
    "Department": "شعبة شؤون الطلبة و التسجيل",
    "Position": "مسؤول وحدة شؤون الطلبة والتسجيل",
    "Phone": 7725412053
  },
  {
    "NationalId": 117642711,
    "Name": "كاظم غانم محي عزيز الغانمي",
    "Department": "شعبة شؤون الديوان",
    "Position": "مسؤول شعبة الخدمات",
    "Phone": 7803745934
  },
  {
    "NationalId": 155324123,
    "Name": "كرار ابراهيم عبد الامير عباس سلومي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7702688166
  },
  {
    "NationalId": 148808522,
    "Name": "ليث كاظم عبد الحسين طاهر الكرافي",
    "Department": "وحدة البريد المركزي والقلم السري",
    "Position": "مسؤول وحدة البريد المركزي والقلم السري",
    "Phone": 7803097175
  },
  {
    "NationalId": 117630112,
    "Name": "ماهر حسن كاظم محسن الساعدي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7710527160
  },
  {
    "NationalId": 117649332,
    "Name": "محاسن زاجي علي بدر الموسوي",
    "Department": "شعبة الشوون المالية والإدارية",
    "Position": "مسوول وحدة التقاعد",
    "Phone": 7723069569
  },
  {
    "NationalId": 117629558,
    "Name": "محسن حسن حسين عباس علو",
    "Department": "علوم الحاسوب",
    "Position": "معاون العميد للشؤون العلمية والدراسات العليا",
    "Phone": 7701661504
  },
  {
    "NationalId": 117802539,
    "Name": "محمد الباقر  هاشم ويس يوسف ال سليمان",
    "Department": "شعبة شؤون الطلبة و التسجيل",
    "Position": null,
    "Phone": 7703397598
  },
  {
    "NationalId": 155324053,
    "Name": "محمد الصادق ضياء عبد الامير عبد النجار",
    "Department": "وحدة التجهيزات",
    "Position": null,
    "Phone": 7713382769
  },
  {
    "NationalId": 117629516,
    "Name": "محمد رضا كاظم جواد الخفاجي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7709657500
  },
  {
    "NationalId": 116142296,
    "Name": "محمد سعدون ضمد محسن",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7905911195
  },
  {
    "NationalId": 148808494,
    "Name": "محمد عبد الرسول محمد حسن كردس",
    "Department": "وحدة الحساب الجاري",
    "Position": null,
    "Phone": 7711336433
  },
  {
    "NationalId": 150028316,
    "Name": "محمد عبد العزيز محمد جديع التميمي",
    "Department": "علوم الحاسوب",
    "Position": "مسوول شعبة التاهيل والتوظيف",
    "Phone": 7740744706
  },
  {
    "NationalId": 151111983,
    "Name": "محمد ماجد محمد عبد الحسن المحمداوي",
    "Department": "الحوكمة الالكترونية",
    "Position": null,
    "Phone": 7735393930
  },
  {
    "NationalId": 117629912,
    "Name": "محمد محسن حسون جواد العبادي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7702751363
  },
  {
    "NationalId": 148818026,
    "Name": "مرتجى صلاح محمد محمد علي جلوخان",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة حدة الحاضنة التكنولوجية والنظام البيئي",
    "Phone": 7807346776
  },
  {
    "NationalId": 155324079,
    "Name": "مرتضى عبد المهدي جبار محمد الحصين",
    "Department": "شعبة شؤون الطلبة و التسجيل",
    "Position": "مسوؤل وحدة تدقيق الوثائق",
    "Phone": 7814024110
  },
  {
    "NationalId": 117645950,
    "Name": "مرفد محمد بكر عطوان السعدي",
    "Department": "مكتب العميد",
    "Position": "مسؤول وحدة مجانية التعليم",
    "Phone": 7810774935
  },
  {
    "NationalId": 148811856,
    "Name": "مروه علي ناصر حسين نصر الله",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": null,
    "Phone": 7712714442
  },
  {
    "NationalId": 155324095,
    "Name": "مريم حسين عبد العباس هاشم الطمازي",
    "Department": "الشوؤن العلمية",
    "Position": "مسوول وحدة الشوون العلمية",
    "Phone": 7732971652
  },
  {
    "NationalId": 151839085,
    "Name": "مصطفى عبد الحسن عبد عون البرقاوي",
    "Department": "الشعبة القانونية",
    "Position": "مسؤول وحدة العقود الحكومية",
    "Phone": 7735302421
  },
  {
    "NationalId": 117630026,
    "Name": "مصطفى عبد الرسول علي محمد الخفاجي",
    "Department": "علوم الحاسوب",
    "Position": "مسوول شعبة الأنظمة والبرمجيات",
    "Phone": 7711336433
  },
  {
    "NationalId": 155324165,
    "Name": "مصطفى محمد حسن محمد جواد الكلش",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7700800797
  },
  {
    "NationalId": 155324040,
    "Name": "مصطفى نزار عليوي وادي الفتلاوي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7732601899
  },
  {
    "NationalId": 155324110,
    "Name": "مقتدى صاحب علي حسين ولي",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": null,
    "Phone": 7811887867
  },
  {
    "NationalId": 117624582,
    "Name": "منار حمزه بشه حسين منيحر",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7906538132
  },
  {
    "NationalId": 117629871,
    "Name": "مها صبري زباله شاكر التميمي",
    "Department": "علوم الحاسوب",
    "Position": "رئيس قسم تكنولوجيا المعلومات",
    "Phone": 7813002911
  },
  {
    "NationalId": 148813568,
    "Name": "مهجه احمد سعيد مجيد الهنداوي",
    "Department": "علوم الحاسوب",
    "Position": "وحدة الاعتماد",
    "Phone": 7711480842
  },
  {
    "NationalId": 117629404,
    "Name": "مهند حيدر محمد باقر الكلابي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7716588251
  },
  {
    "NationalId": 117629475,
    "Name": "مهند كامل عبد الحميد مكي المحنه",
    "Department": "علوم الحاسوب",
    "Position": "رئيس قسم علوم الحاسوب",
    "Phone": 7719544055
  },
  {
    "NationalId": 117623055,
    "Name": "موفق كاظم محسن حمادي ال عبود",
    "Department": "تكنلوجيا المعلومات",
    "Position": "عميد كلية علوم الحاسوب وتكنلوجيا المعلومات",
    "Phone": 7718008874
  },
  {
    "NationalId": 117630604,
    "Name": "ميثم جواد عبد خضير العماري",
    "Department": "شعبة الخدمات",
    "Position": "مسؤول الوحدة الزراعية",
    "Phone": 7711914580
  },
  {
    "NationalId": 117629714,
    "Name": "ميراس سلمان جواد عواد الشمري",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7741939018
  },
  {
    "NationalId": 117629970,
    "Name": "ميس سعد صفوك سعود المسعودي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7810712655
  },
  {
    "NationalId": 148813018,
    "Name": "نغم حبيب شاكر حمزه المسعودي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7714875905
  },
  {
    "NationalId": 151439939,
    "Name": "نور الهدى عبد الحسين هادي عبود",
    "Department": "شعبة الدراسات العليا",
    "Position": null,
    "Phone": 7846106659
  },
  {
    "NationalId": 155324082,
    "Name": "نور حسن هادي ابراهيم الشجيري",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7800018036
  },
  {
    "NationalId": 117629417,
    "Name": "نور ضياء كاظم جواد الشكرجي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7707208020
  },
  {
    "NationalId": 151123199,
    "Name": "نور غالب عبيس عبود",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7803859527
  },
  {
    "NationalId": 117629785,
    "Name": "هبه جبار عبد الواحد كريم العقابي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7712734264
  },
  {
    "NationalId": 117629532,
    "Name": "هبه عدنان رحيم علي المحمد",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة التأهيل والتوظيف والمتابعة",
    "Phone": 7711730074
  },
  {
    "NationalId": 101325084,
    "Name": "هبه منذر حسين جواد الحبوبي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7709657400
  },
  {
    "NationalId": 117630831,
    "Name": "هدى راغب كاظم جبار الشبوط",
    "Department": "علوم الحاسوب",
    "Position": "وحدة اعتماد المختبرات",
    "Phone": 7708027644
  },
  {
    "NationalId": 151113286,
    "Name": "هدى فاضل حنش ناصر الخفاجي",
    "Department": "تكنلوجيا المعلومات",
    "Position": "مسؤول وحدة البعثات والعلاقات",
    "Phone": 7734628601
  },
  {
    "NationalId": 117629644,
    "Name": "هدى فاضل علوان عبود حلاوي",
    "Department": "تكنلوجيا المعلومات",
    "Position": null,
    "Phone": 7813758405
  },
  {
    "NationalId": 155324066,
    "Name": "هدير ماجد عبد الحسين ياسين الهنداوي",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة المكتبة الالكترونية",
    "Phone": 7830974819
  },
  {
    "NationalId": 117628162,
    "Name": "هشام رحيم حنظل واوي الرحيمي",
    "Department": "شعبة الخدمات",
    "Position": null,
    "Phone": null
  },
  {
    "NationalId": 155324181,
    "Name": "همام عزيز غازي كاظم الدعمي",
    "Department": "مكتب المعاون العلمي",
    "Position": null,
    "Phone": 7801039533
  },
  {
    "NationalId": 151113400,
    "Name": "هناء علي مزهر الكاصد",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7860111203
  },
  {
    "NationalId": 117641958,
    "Name": "هيثم محمد حسين صالح مهدي الغرابي",
    "Department": "علوم الحاسوب",
    "Position": "مقرر قسم علوم الحاسوب",
    "Phone": 7819737694
  },
  {
    "NationalId": 151113455,
    "Name": "وائل حسن علي ال محمد",
    "Department": "علوم الحاسوب",
    "Position": "مسؤول وحدة الانترنت والشبكات",
    "Phone": 7803209181
  },
  {
    "NationalId": 117630646,
    "Name": "وداد رزاق عيدان مهدي الحمداني",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": "مسؤول وحدة التوظيف والملاك",
    "Phone": 7734018291
  },
  {
    "NationalId": 117630448,
    "Name": "وسن عزيز ناصر حسين التميمي",
    "Department": "وحدة الترقيات",
    "Position": null,
    "Phone": 7708901650
  },
  {
    "NationalId": 117625684,
    "Name": "وسن معطي هادي حسن الفتلاوي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7721482942
  },
  {
    "NationalId": 117629839,
    "Name": "وفاء شاكر محمد حسن الربيعي",
    "Department": "علوم الحاسوب",
    "Position": null,
    "Phone": 7702751239
  },
  {
    "NationalId": 152297563,
    "Name": "وليد سرحان مطر سويف الصالحي",
    "Department": "شعبة الاعلام والاتصال الحكومي",
    "Position": "مسؤول وحدة الارشاد النفسي والتوجيه التربوي",
    "Phone": 7723969139
  },
  {
    "NationalId": 117625460,
    "Name": "يوسف خليل سعد خضير اليساري",
    "Department": "شعبة الشؤون الادارية والمالية",
    "Position": null,
    "Phone": 7721467270
  },
  {
    "NationalId": 152938295,
    "Name": "حسين علي محسن عذاب اليساري",
    "Department": "مكتب المعاون الإداري",
    "Position": null,
    "Phone": 7806730455
  },
  {
    "NationalId": 148815522,
    "Name": "امال قيس شاكر احمد العبادي",
    "Department": null,
    "Position": null,
    "Phone": 7811188085
  },
  {
    "NationalId": 101822035,
    "Name": "نسرين فليح حسن نصيف الخيلاني",
    "Department": null,
    "Position": null,
    "Phone": 7712761657
  },
  {
    "NationalId": 3,
    "Name": "مصطفى عيسى عكاب كاطع",
    "Department": null,
    "Position": null,
    "Phone": 7717753012
  }
]
""";

    /// <summary>
    /// Seeds the employees table with CSIT employees data if the table is empty
    /// </summary>
    /// <param name="unitOfWork">The unit of work for database operations</param>
    /// <returns>Task representing the async operation</returns>
    public async Task SeedEmployeesAsync(UnitOfWork unitOfWork)
    {
        try
        {
            // Check if employees table is empty
            var existingEmployees = await unitOfWork.EmployeesRepository.GetAllAsync();
            if (existingEmployees.Any())
            {
                Console.WriteLine("Employees table already contains data. Skipping seed operation.");
                return;
            }

            Console.WriteLine("Employees table is empty. Starting seed operation...");
            
            // Deserialize JSON data
            var employeeDataList = JsonSerializer.Deserialize<List<EmployeeSeedData>>(CSIT_EmployeesNamesAsJson);
            
            if (employeeDataList == null || !employeeDataList.Any())
            {
                Console.WriteLine("No employee data found in JSON. Seed operation cancelled.");
                return;
            }

            // Convert to Employee entities
            var employees = employeeDataList.Select(data => new Employee
            {
                Name = data.Name ?? string.Empty,
                Department = data.Department,
                Position = data.Position,
                NationalId = data.NationalId?.ToString(),
                Phone = data.Phone?.ToString(),
                Email = null // Not provided in the seed data
            }).ToList();

            // Bulk insert employees
            await unitOfWork.EmployeesRepository.BulkSaveAsync(employees);
            await unitOfWork.CommitAsync();

            Console.WriteLine($"Successfully seeded {employees.Count} employees to the database.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while seeding employees data: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Static method to seed employees data - can be called from anywhere in the application
    /// </summary>
    /// <returns>Task representing the async operation</returns>
    public static async Task SeedEmployeesIfEmptyAsync()
    {
        try
        {
            var seedData = new SeedData();
            using var unitOfWork = new UnitOfWork();
            await seedData.SeedEmployeesAsync(unitOfWork);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred during static seed operation: {ex.Message}");
            throw;
        }
    }
}

/// <summary>
/// DTO class for deserializing employee seed data from JSON
/// </summary>
public class EmployeeSeedData
{
    public long? NationalId { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public string? Position { get; set; }
    public long? Phone { get; set; }
}