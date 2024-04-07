using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddEditStudentForm : Form
    {
        // make new services for student and room as a global variable
        StudentService studentService = new StudentService();
        RoomService roomService = new RoomService();

        // global variable for the current student which will be the student that was chosen in the list
        Student currentStudent = new Student();


        // this form is for adding a new student
        public AddEditStudentForm()
        {
            InitializeComponent();
            // make sure the text above the form says add new student
            Text = "Add new student";
            // hiding the edit button since this is going to be the add new student form
            btnEdit.Hide();

            // filling the combo box with all the rooms already in the database
            // i chose a combobox instead of a textbox because room number is the primary key of room table and foreign key to student table
            // so only an existing room can be chosen
            List<Room> rooms = roomService.GetRooms();
            foreach (Room room in rooms)
            {
                comboBoxRoom.Items.Add(room.Number);
            }
            // as default show the first option so it won't be empty
            comboBoxRoom.SelectedIndex = 0;
        }

        //  this form is for changing an already existing student
        // overloaded the method so it recieves the current student which is selected in the list
        public AddEditStudentForm(Student student)
        {
            InitializeComponent();

            // make sure the text above the form says edit student
            Text = "Edit student";

            // hiding the add button since this is only for editing
            btnAdd.Hide();

            // pass the chosen student to global variable current student and fill the textboxes with already available data
            currentStudent = student;
            FillTexbox();

            // hide the parts from the add student form and resize the page so it doesn't look weird
            lblStudentNumber.Hide();
            lblRoomNumber.Hide();
            textBoxStudentNumber.Hide();
            comboBoxRoom.Hide();
            ClientSize = new System.Drawing.Size(480, 380);
        }

        // Add a new student after the button has been clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // use the seperate method here to create a new student
                Student student = CreateStudent();

                // pass it on to be created in the database
                studentService.AddStudent(student);

                // close the form
                Close();
            }
            catch (Exception exception)
            {
                // create a new error message that checks if the exception thrown is an sql exception or not
                // since the only sql exception that could be thrown here is the primary key error then it will show the message
                // if not, it will show the default message
                string errorMessage = exception is SqlException ? "This student already exists." : exception.Message;
                MessageBox.Show(errorMessage);
            }
        }

        // seperate method to create a student cause it's fancier
        private Student CreateStudent()
        {
            Student student = new Student();
            // make sure it only adds a new student number and room number if we want to add a new student to the database and not for editing
            // Per oral instructions, the student number and room number shouldn't be changed in changing an existing student so I did it this way
            if (Text.Equals("Add new student"))
            {
                student.StudentNumber = TextBoxParseInt(textBoxStudentNumber.Text, "So close! That's not a valid student number.");
                student.RoomNumber = comboBoxRoom.SelectedItem.ToString();
            }
            student.FirstName = TextBoxEmpty(textBoxFirstName.Text, "So close! That's not a first name.");
            student.LastName = TextBoxEmpty(textBoxLastName.Text, "So close! That's not a last name.");
            student.Telephone = TextBoxParseInt(textBoxTelephone.Text, "So close! That's not a valid telephone number.");
            student.Class = TextBoxEmpty(textBoxClass.Text, "So close! That's not a class.");
            return student;
        }

        //  a method to make sure the textbox is not empty, if yes then throw an exception
        private string TextBoxEmpty(string textboxString, string errorMessage)
        {
            if (textboxString == null || textboxString == string.Empty)
                throw new Exception(errorMessage);

            return textboxString;
        }

        // a method to make sure the input is an int
        private int TextBoxParseInt(string textboxString, string errorMessage)
        {
            if (!int.TryParse(textboxString, out int intNumber))
                throw new Exception(errorMessage);

            return intNumber;
        }

        // edit the student after clicking the edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // make a new instance of student which doesn't include student number and room number based on the textboxes
                Student student = CreateStudent();

                // set the new instance's room number and student number to the current student's id and room number
                student.StudentNumber = currentStudent.StudentNumber;
                student.RoomNumber = currentStudent.RoomNumber;

                // call on the method to change student from the service
                studentService.ChangeStudent(student);

                // close the form
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // method to pre-fill the textboxes based on the selected item
        private void FillTexbox()
        {
            textBoxFirstName.Text = currentStudent.FirstName;
            textBoxLastName.Text = currentStudent.LastName;
            textBoxTelephone.Text = currentStudent.Telephone.ToString();
            textBoxClass.Text = currentStudent.Class;
        }
    }
}
