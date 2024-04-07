using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class CreateDrinkForm : Form
    {
        // intialize the drink service
        DrinkService drinkService = new DrinkService();

        // global variable for a drink
        Drink currentDrink = new Drink();

        // make sure it's a create form
        public CreateDrinkForm()
        {
            InitializeComponent();
            Text = "Create drink";
            btnUpdate.Hide();
        }

        // make sure it's an edit form
        public CreateDrinkForm(Drink drink)
        {
            InitializeComponent();
            Text = "Edit drink";
            btnCreate.Hide();
            currentDrink = drink;
            FillTexbox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // use the seperate method here to create the drink
                Drink drink = CreateDrink();

                // pass it on to be created in the database
                drinkService.CreateDrink(drink);

                // close the form
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // seperate method to create a drink cause it's fancier
        private Drink CreateDrink()
        {
            Drink drink = new Drink();
            drink.Name = TextBoxEmpty(textBoxName.Text, "So close! That's not a name.");
            drink.Alcoholic = rdoYes.Checked;
            drink.Price = TextBoxParseDecimal(textBoxPrice.Text, "So close! That's not a price.");
            drink.Stock = TextBoxParseInt(textBoxStock.Text, "So close! That's not a number for stock.");
            return drink;
        }

        //  a method to make sure the textbox is not empty, if yes then throw an exception
        private string TextBoxEmpty(string textboxString, string errorMessage)
        {
            if (textBoxName.Text == null || textBoxName.Text == string.Empty)
                throw new Exception(errorMessage);

            return textboxString;

        }

        // a method to make sure the price is actually a decimal
        private double TextBoxParseDecimal(string textboxString, string errorMessage)
        {
            if (!double.TryParse(textboxString, out double decimalNumber))
                throw new Exception(errorMessage);

            return decimalNumber;
        }

        // a method to make sure the input is a int
        private int TextBoxParseInt(string textboxString, string errorMessage)
        {
            if (!int.TryParse(textboxString, out int intNumber))
                throw new Exception(errorMessage);

            return intNumber;
        }


        // method to edit drink 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
      
            try
            {
                Drink drink = CreateDrink();
                drink.DrinkID = currentDrink.DrinkID;
                drinkService.UpdateDrink(drink);
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
            textBoxName.Text = currentDrink.Name;
            textBoxPrice.Text = currentDrink.Price.ToString();
            textBoxStock.Text = currentDrink.Stock.ToString();
            // radio button to whatever that was
            if (currentDrink.Alcoholic)
                rdoYes.Checked = true;
            else
                rdoNo.Checked = true;
        }

    }
}
