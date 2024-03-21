using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            //testing stuff
            ShowDashboardPanel();
        }
        private void HideAllPanels()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            //RoomPanel here
            //LecturerPanel here
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
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                listViewStudents.Items.Add(CreateStudentListViewItem(student));
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
    }
}