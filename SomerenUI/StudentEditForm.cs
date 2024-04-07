using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenDAL;
using System.Configuration;

namespace SomerenUI
{
    public partial class StudentEditForm : Form
    {
        public StudentEditForm()
        {
            InitializeComponent();
            StudentDao studentDao = new StudentDao();
            List<Student> students = studentDao.GetAllStudents();
            foreach (Student student in students)
            {
                
                //.SelectBox.Items.Add(student);
            }
        }


    }
}
