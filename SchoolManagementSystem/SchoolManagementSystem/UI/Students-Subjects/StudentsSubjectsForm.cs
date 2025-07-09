using SchoolManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Students_Subjects
{
    public partial class StudentsSubjectsForm : Form
    {
        private readonly SubjectsDal subjectsDal;
        private readonly StudentsSubjectsDal studentSubjectsDal;
        private readonly int studentId;


        public StudentsSubjectsForm()
        {
            InitializeComponent();
            subjectsDal = new SubjectsDal(); // Initialize the instance
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            var subjects = subjectsDal.GetAllSubjects(); // Use the instance to call the method

            lvsubjectsstudents.Items.Clear();

            foreach (DataRow row in subjects.Rows)
            {
                var item = new ListViewItem(row["name"].ToString())
                {
                    Tag = Convert.ToInt32(row["id"])
                };
                lvsubjectsstudents.Items.Add(item);
            }
        }   
    }

}
