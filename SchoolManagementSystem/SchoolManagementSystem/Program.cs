using SchoolManagementSystem.DAL;
using SchoolManagementSystem.Model;
using SchoolManagementSystem.UI.Grades;
using SchoolManagementSystem.UI.Grades_Subjects;
using SchoolManagementSystem.UI.Students;
using SchoolManagementSystem.UI.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
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
            Application.Run(new SubjectsGrades());
        }
    }
}
