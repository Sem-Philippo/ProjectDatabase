using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class ManagingStudent : Form
    {
        private SomerenUI somerenUI;

        public ManagingStudent(SomerenUI somerenUI)
        {
            this.somerenUI = somerenUI;
            InitializeComponent();
            FillRoomsDropdown();
            FillClassDropdown();
        }
        private void FillRoomsDropdown()
        {
            List<Room> rooms = GetRooms();

            RoomNrBox.Items.Clear();

            foreach (Room room in rooms)
            {
                RoomNrBox.Items.Add(room.Number.ToString());
            }
        }


        private List<Room> GetRooms()
        {
            RoomDao dao = new RoomDao();
            List<Room> rooms = dao.GetAllRooms();

            return rooms;
        }
        private void FillClassDropdown()
        {
            List<string> classes = GetClasses();

            ClassNameBox.Items.Clear();

            foreach (string cls in classes)
            {
                ClassNameBox.Items.Add(cls);
            }
        }

        private List<string> GetClasses()
        {
            StudentDao dao = new StudentDao();
            List<string> classes = dao.GetAllClasses();

            return classes;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // Check if all the controls are filled...........
            if (string.IsNullOrWhiteSpace(StudentNameBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberBox.Text) ||
                string.IsNullOrWhiteSpace(ClassNameBox.Text) ||
                string.IsNullOrWhiteSpace(RoomNrBox.Text))
            {
                MessageBox.Show("Please fill out all the boxes correctly");
                return;
            }

           Student newStudent = new Student();
            newStudent.Name = StudentNameBox.Text;
            newStudent.PhoneNumber = PhoneNumberBox.Text;
            newStudent.Class = ClassNameBox.Text;
            newStudent.RoomNumber = int.Parse(RoomNrBox.Text);

            StudentDao dao = new StudentDao();

             dao.InsertStudent(newStudent);

            MessageBox.Show("Student added successfully!");
            somerenUI.ShowStudentsPanel();
            this.Close();
            
        }

    }

}
