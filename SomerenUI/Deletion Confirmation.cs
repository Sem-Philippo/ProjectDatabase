using SomerenDAL;
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

namespace SomerenUI
{
    public partial class Deletion_Confirmation : Form
    {
        public Deletion_Confirmation(object person, Activity activity)
        {
            InitializeComponent();
            btnConfirm.Tag = person;
            lblDeletion.Tag = activity;
            if (btnConfirm.Tag.GetType() == typeof(Teacher))
            {
                lblDeletion.Text = "Are you sure you wish to remove this supervisor?";
            }
            else
            {
                lblDeletion.Text = "Are you sure you wish to remove this participant?";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //store the activity in the lbl, store the Teacher or Student in the button
            if (btnConfirm.Tag.GetType() == typeof(Teacher))
            {
                SupervisorDAO supervisorDAO = new SupervisorDAO();
                supervisorDAO.RemoveSupervisor(((Teacher)btnConfirm.Tag).Id, (Activity)lblDeletion.Tag);
            }
            else if (btnConfirm.Tag.GetType() == typeof(Student))
            {
                StudentDao studentDao = new StudentDao();
                //studentDao.RemoveParticipant
            }
            //Add student here, if you use the same method!

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
