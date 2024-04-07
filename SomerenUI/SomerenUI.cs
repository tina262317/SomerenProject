using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        // drink service 
        DrinkService drinkService = new DrinkService();
        StudentService studentService = new StudentService();
        // *room service by pitbull starts playing*
        // no but seriously you have to initialize the room service so it gets all the methods related to rooms and whatnot
        RoomService roomService = new RoomService();
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        // a generic method to show the panels
        private void ShowPanel(Panel panel)
        {
            string panelName = "pnl";

            // hide all panels
            foreach (Control control in Controls)
                if (control.Name.StartsWith(panelName)) control.Hide();

            // show the panel that got passed on
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
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.StudentNumber.ToString());
                li.SubItems.Add(student.RoomNumber);
                li.SubItems.Add(student.FirstName);
                li.SubItems.Add(student.LastName);
                li.SubItems.Add(student.Telephone.ToString());
                li.SubItems.Add(student.Class);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }


        // show the rooms panel 
        private void ShowRoomsPanel()
        {
            // hide all other panels
            ShowPanel(pnlRooms);

            // show rooms panel
            pnlRooms.Show();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }


        // get all rooms
        private List<Room> GetRooms()
        {
            
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        // display all rooms
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {

                string type = room.Type ? "Lecturer" : "Student";
                ListViewItem li = new ListViewItem(room.Number);
                li.SubItems.Add(room.NumberOfBeds.ToString());
                li.SubItems.Add(type);
                li.Tag = room;   // link room object to listview item
                listViewRooms.Items.Add(li);
            }
        }

        // show the drinks panel 
        private void ShowDrinksPanel()
        {
            // hide all other panels
            ShowPanel(pnlDrinks);

            // show rooms panel
            pnlDrinks.Show();

            try
            {
                // get and display all rooms
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        // get all drinks
        private List<Drink> GetDrinks()
        {

            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        // display all drinks
        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {


                //"Are you an alcoholic? Be honest to me" question for the drink, not for you
                // sorry for the bad jokes, my sense of humour gets broken after a few hours of coding
                string alcoholic = drink.Alcoholic ? "Yes" : "No";


                ListViewItem li = new ListViewItem(drink.Name);
                li.SubItems.Add(alcoholic);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.Stock.ToString());
                li.SubItems.Add(drink.StockStatus.ToString());
                li.Tag = drink;   // link room object to listview item
                listViewDrinks.Items.Add(li);
            }
        }

        // click button event to open a form to create a drink
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateDrinkForm createDrinkForm = new CreateDrinkForm();
            createDrinkForm.ShowDialog();
            ShowDrinksPanel();
        }

        // click button event to just delete existence 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
            drinkService.DeleteDrink(drink);
            ShowDrinksPanel();
        }

        // click button event to edit one drink
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
            CreateDrinkForm createDrinkForm = new CreateDrinkForm(drink);
            createDrinkForm.ShowDialog();
            ShowDrinksPanel();

        }

        // The clicl events for the menu
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }
    }
}