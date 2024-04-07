using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.LinkLabel;
using Microsoft.VisualBasic;
using System.Data.Common;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        // drink and student service as global variables
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

        // Method to show the dashboard
        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        // method to show the students
        private void ShowStudentsPanel()
        {
            // show the students panel and hide everything else
            ShowPanel(pnlStudents);

            // error handling done for the server
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

        // method gets all students from the student service
        private List<Student> GetStudents()
        {
            List<Student> students = studentService.GetStudents();
            return students;
        }

        // method displays all students in the panel
        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            // fill each column with information recieved 
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

        // method opens the form for creating a new student if the add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditStudentForm addStudentForm = new AddEditStudentForm();
            addStudentForm.ShowDialog();

            // refresh the students panel so new information shows up
            ShowStudentsPanel();
        }

        // method opens the edit form if the edit button is clicked
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // only open the edit form if an item is chosen
                if (listViewStudents.SelectedItems.Count > 0)
                {
                    // get the chosen student and pass it to the edit form
                    Student student = (Student)listViewStudents.SelectedItems[0].Tag;
                    AddEditStudentForm editStudentForm = new AddEditStudentForm(student);
                    editStudentForm.ShowDialog();

                    // refresh the students panel so new information shows up
                    ShowStudentsPanel();
                }
                // if no item is selected throw an error
                else
                {
                    throw new Exception("You need to select a student!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // method deletes a chosen student if the delete button is clicked
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // first check if any item is selected or not
                if (listViewStudents.SelectedItems.Count > 0)
                {
                    // add a message box to get confirmation for deleting the student
                    string messageTop = "Confirmation needed";
                    string messageText = "Are you sure you wish to remove this student?";
                    DialogResult result = MessageBox.Show(messageText, messageTop, MessageBoxButtons.YesNo);

                    // if the user says yes then delete the student
                    if (result == DialogResult.Yes)
                    {
                        Student student = (Student)listViewStudents.SelectedItems[0].Tag;
                        studentService.DeleteStudent(student);
                        ShowStudentsPanel();
                    }
                }
                // if no student is selected then throw an error
                else
                {
                    throw new Exception("You need to select a student!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // show the rooms panel 
        private void ShowRoomsPanel()
        {
            // hide all other panels
            ShowPanel(pnlRooms);

            // error handling for the server
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

            // fill each column with information recieved 
            foreach (Room room in rooms)
            {
                // type is a bool so a string based on the result of type
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

            // error handling for the server
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

            //fill each column with information recieved
            foreach (Drink drink in drinks)
            {
                //"Are you an alcoholic? Be honest to me" question for the drink, not for the user
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

        // click button event to edit one drink
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // only open the edit form if an item is chosen
                if (listViewDrinks.SelectedItems.Count > 0)
                {
                    // get the chosen drink and pass it to the edit form
                    Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                    CreateDrinkForm createDrinkForm = new CreateDrinkForm(drink);
                    createDrinkForm.ShowDialog();

                    // refresh the students panel so new information shows up
                    ShowDrinksPanel();
                }
                // if no item is selected throw an error
                else
                {
                    throw new Exception("You need to select a drink!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // click button event to just delete existence 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // only delete if an item is chosen
                if (listViewDrinks.SelectedItems.Count > 0)
                {
                    // get the chosen drink and delete it
                    Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                    drinkService.DeleteDrink(drink);
                    ShowDrinksPanel();
                }
                // if no item is selected throw an error
                else
                {
                    throw new Exception("You need to select a drink!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // The click events for the menu
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