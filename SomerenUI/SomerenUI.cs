using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenService;
using SomerenModel;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            //quick test
            ShowDashboardPanel();
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
        private void HideAllPanels()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            //RoomPanel here
            panelLecturers.Hide();
            //activity panel here
            pnlDrinks.Hide();
            //any other panels here
        }
        private void ShowPanel(Panel panel)
        {
            //hide all panels 
            HideAllPanels();
            //show the panel that should be shown
            panel.Show();
        }
        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
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
            ShowPanel(pnlStudents);

            try
            {
                //get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowDrinksPanel()
        {
            ShowPanel(pnlDrinks);
            try
            {
                //get and display all drinks
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }
        private void DisplayDrinks(List<Drink> drinks)
        {
            //clear the listview before filling it
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            { 
                listViewDrinks.Items.Add(CreateDrinkListViewItem(drink));
            }
        }
        private ListViewItem CreateDrinkListViewItem(Drink drink)
        {
            string[] subItems = new string[6] { 
                    drink.Name,
                    drink.StockAmount.ToString(),
                    "Stock " + drink.IsSufficient.ToString().Replace("_", " "),
                    drink.Price.ToString("0.00"),
                    drink.Alcoholic.ToString(),
                    drink.VAT.ToString("0.00") };
            ListViewItem li = new ListViewItem(subItems);
            li.Tag = drink;   // link student object to listview item
            return li;
        }
        private ListViewItem CreateStudentListViewItem(Student student)
        {
            string[] subItems = new string[4] { student.Number.ToString(), student.Name,
                    student.Class, student.PhoneNumber };
            ListViewItem li = new ListViewItem(subItems);
            li.Tag = student;   // link student object to listview item
            return li;
        }
        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                listViewStudents.Items.Add(CreateStudentListViewItem(student));
            }
        }

        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();

            // show lecturers
            panelLecturers.Show();

            try
            {
                // get and display all lecturers
                List<Teacher> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private List<Teacher> GetLecturers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> lecturers = teacherService.GetTeachers();
            return lecturers;
        }

        private void DisplayLecturers(List<Teacher> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();

            foreach (Teacher lecturer in lecturers)
            {
                ListViewItem li = CreateListViewItem(lecturer);
                listViewLecturers.Items.Add(li);
            }
        }

        private ListViewItem CreateListViewItem(Teacher lecturer)
        {
            ListViewItem li = new ListViewItem(lecturer.Name);
            //li.SubItems.Add(lecturer.Name);
            li.SubItems.Add(lecturer.AgeInYears.ToString());
            li.SubItems.Add(lecturer.PhoneNumber);
            li.Tag = lecturer;   // link teacher object to listview item
            return li;
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void btnEditDrinks_Click(object sender, EventArgs e)
        {
            DrinkEditForm drinkEditForm = new DrinkEditForm();
            drinkEditForm.ShowDialog();
            ShowDrinksPanel();
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
    }
}
