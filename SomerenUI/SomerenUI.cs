using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }
        private void HideAllPanels()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            RoomsPanel.Hide();
            //LecturerPanel here
            //activity panel here
            //drink panel here
            //any other panels here
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();

            // show dashboard
            pnlDashboard.Show();
        }
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                // Determine the room type based on the number of beds
                string roomType = room.Beds > 1 ? "Student" : "Lecturer";

                // Include the room type in the subItems array
                string[] subItems = new string[5] { room.Number.ToString(), room.Floor.ToString(), room.Building.ToString(), room.Beds.ToString(), roomType };

                // Create a new ListViewItem with the subItems array
                ListViewItem li = new ListViewItem(subItems);
                li.Tag = room;   // link room object to listview item

                // Add the new ListViewItem to the listViewRooms
                listViewRooms.Items.Add(li);
            }

        }
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        private void ShowRoomsPanel()
        {
            HideAllPanels();

            RoomsPanel.Show();

            try
            {
                // get and display all rooms
                List<Room> room = GetRooms();
                DisplayRooms(room);
                //  RoomsPanel.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();

        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
    }
}