using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenService;
using SomerenModel;
using SomerenDAL;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }
        private void HideAllPanels()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            panelLecturers.Hide();
            RoomsPanel.Hide();
            //activity panel here
            pnlDrinks.Hide();
            pnlSupervisors.Hide();
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
                // Add the new ListViewItem to the listViewRooms
                listViewRooms.Items.Add(CreateRoomListViewItem(room));
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
            ShowPanel(RoomsPanel);

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
        private void ShowSupervisorsPanel()
        {
            ShowPanel(pnlSupervisors);
            UpdateActivityBox();

        }
        private void UpdateActivityBox()
        {
            ActivityDAO activityDao = new ActivityDAO();
            List<Activity> activities = activityDao.GetAllActivities();
            comboBoxActivities.Items.Clear();
            foreach (Activity activity in activities)
            {
                comboBoxActivities.Items.Add(activity);
            }
            comboBoxActivities.SelectedIndex = 0;
            //update the listviews just in case
            UpdateSupervisors();
        }
        private void UpdateSupervisors()
        {

            Activity activity = ((Activity)comboBoxActivities.Items[comboBoxActivities.SelectedIndex]);
            //get supervisor listview
            //clear it
            listViewSupervising.Items.Clear();
            //get all supervisors for the activity
            SupervisorDAO supervisorDAO = new SupervisorDAO();
            List<Teacher> supervisors = supervisorDAO.GetSupervisorsByActivity(activity);
            //add all supervisors for the activity
            foreach (Teacher teacher in supervisors)
            {
                listViewSupervising.Items.Add(CreateSupervisorListViewItem(teacher));
            }
            //get other listview
            //clear it too
            listViewNotSupervising.Items.Clear();
            //add all lecturers who aren't supervising the activity
            //the sql command only gets those who aren't already supervising the selected activity
            supervisors = supervisorDAO.GetNonSupervisorsByActivity(activity);
            foreach (Teacher teacher in supervisors)
            {
                listViewNotSupervising.Items.Add(CreateSupervisorListViewItem(teacher));
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
            li.Tag = drink;   // link drink object to listview item
            return li;
        }
        private ListViewItem CreateRoomListViewItem(Room room)
        {
            // Determine the room type based on the number of beds
            string roomType = room.Beds > 1 ? "Student" : "Lecturer";

            // Include the room type in the subItems array
            string[] subItems = new string[5] { room.Number.ToString(), room.Floor.ToString(), room.Building.ToString(), room.Beds.ToString(), roomType };

            // Create a new ListViewItem with the subItems array
            ListViewItem li = new ListViewItem(subItems);
            li.Tag = room;   // link room object to listview item
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
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                listViewStudents.Items.Add(CreateStudentListViewItem(student));
            }
        }

        private void ShowLecturersPanel()
        {
            ShowPanel(panelLecturers);

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
                ListViewItem li = CreateLecturerListViewItem(lecturer);
                listViewLecturers.Items.Add(li);
            }
        }

        private ListViewItem CreateLecturerListViewItem(Teacher lecturer)
        {
            ListViewItem li = new ListViewItem(lecturer.Name);
            //li.SubItems.Add(lecturer.Name);
            li.SubItems.Add(lecturer.AgeInYears.ToString());
            li.SubItems.Add(lecturer.PhoneNumber);
            li.Tag = lecturer;   // link teacher object to listview item
            return li;
        }
        private ListViewItem CreateSupervisorListViewItem(Teacher lecturer)
        {
            string[] subItems = new string[2] {
                lecturer.Id.ToString(),
                lecturer.Name,
            };
            ListViewItem li = new ListViewItem(subItems);
            li.Tag = lecturer;
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

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
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
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void activitySupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSupervisorsPanel();
        }
        private void comboBoxActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSupervisors();
        }

        private void listViewSupervising_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = DoHitTest(listViewSupervising, e);
            if (item != null)
            {
                int supervisorId = int.Parse(item.Text);
                TeacherDao teacherDao = new TeacherDao();
                //Got this from internet... Anyways,
                //the fields are as following: The text the box should show, the name of the messagebox (left empty in this case)
                //and the buttons you want (normally you get 1 button)
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this supervisor?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //user confirmed the removal of supervisor, so remove it
                    SupervisorDAO supervisorDAO = new SupervisorDAO();
                    supervisorDAO.RemoveSupervisor(supervisorId, (Activity)comboBoxActivities.SelectedItem);
                }
            }
            UpdateSupervisors();
        }
        private void listViewNotSupervising_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = DoHitTest(listViewNotSupervising, e);
            if (item != null)
            {
                int supervisorId = int.Parse(item.Text);
                SupervisorDAO supervisorDao = new SupervisorDAO();
                supervisorDao.AddSupervisor(supervisorId, ((Activity)comboBoxActivities.Items[comboBoxActivities.SelectedIndex]));
            }
            UpdateSupervisors();
        }
        private ListViewItem DoHitTest(System.Windows.Forms.ListView listView, MouseEventArgs e)
        {
            //HitTest is from the internet, the double click method I could probably have figured out myself
            //This method can also be used for participants and is not exclusive to supervisors (if you do it the same way I did)!
            ListViewHitTestInfo info = listView.HitTest(e.X, e.Y);
            return info.Item;
        }
    }
}
