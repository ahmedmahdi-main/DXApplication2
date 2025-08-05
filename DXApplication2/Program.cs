using DevExpress.XtraEditors;
using DXApplication2.Forms.Employees;
using DXApplication2.Services;
using System;
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
           

            Application.Run(new EmployeesFrom());
        }
    }
}
