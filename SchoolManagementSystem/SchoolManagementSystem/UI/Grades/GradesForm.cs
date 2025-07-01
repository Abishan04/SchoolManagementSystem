using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI.Grades
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }
        private void SetButtonRoundedRegion(Button button, int radius = 20)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }
        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
            SetButtonRoundedRegion(btnadd);
            SetButtonRoundedRegion(btnsub);
            SetButtonRoundedRegion(btnex);
            SetButtonRoundedRegion(btnrefresh);
            SetButtonRoundedRegion(btnprint);
            SetButtonRoundedRegion(btnclose);
            SetButtonRoundedRegion(btndel);
        }
        private int selectedGradeId = 0;
        GradesDal dal = new GradesDal();
        private void LoadGrades()
        {
            dgvGrades.DataSource = dal.GetAllGrades();
            dgvGrades.ClearSelection();
            selectedGradeId = 0;
        }

       

        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
     

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
