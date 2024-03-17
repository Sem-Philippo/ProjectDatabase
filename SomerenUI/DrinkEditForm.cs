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
using SomerenDAL;
using System.Configuration;

namespace SomerenUI
{
    public partial class DrinkEditForm : Form
    {
        public DrinkEditForm()
        {
            InitializeComponent();
            DrinkDao drinkDao = new DrinkDao();
            List<Drink> drinks = drinkDao.GetAllDrinks();
            foreach (Drink drink in drinks)
            {
                DrinkSelectBox.Items.Add(drink);
            }
            pnlEditDrink.Hide();
            pnlNewDrink.Hide();
        }

        private void DrinkSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DrinkSelectBox.SelectedIndex == 0)
            {
                pnlEditDrink.Hide();
                pnlNewDrink.Show();
                //NewDrinkPanel
            }
            else
            {
                pnlNewDrink.Hide();
                pnlEditDrink.Show();
                Drink currentDrink = ((Drink)DrinkSelectBox.Items[DrinkSelectBox.SelectedIndex]);
                txtDrinkName.Text = currentDrink.Name;
                numStock.Value = currentDrink.StockAmount;
                if (currentDrink.Alcoholic)
                {
                    ComboBoxAlcoholic.SelectedIndex = 0;
                }
                else
                {
                    ComboBoxAlcoholic.SelectedIndex = 1;
                }
                txtDrinkPrice.Text = currentDrink.Price.ToString("00.00");
                //ChangeDrinkPanel
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkDao drinkDao = new DrinkDao();
                Drink drink = new Drink();
                drink.Name = txtDrinkName.Text;
                drink.StockAmount = (int)numStock.Value;
                drink.Id = DrinkSelectBox.SelectedIndex;
                if (ComboBoxAlcoholic.SelectedIndex == 0)
                {
                    drink.Alcoholic = true;
                }
                else { drink.Alcoholic = false; }
                drink.Price = float.Parse(txtDrinkPrice.Text);
                drinkDao.SaveExistingDrink(drink);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while updating the selected drink: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DrinkDao drinkDao = new DrinkDao();
            Drink drink = new Drink();
            drink.Name = txtDrinkName.Text;
            drink.StockAmount = (int)numStock.Value;
            drink.Id = DrinkSelectBox.SelectedIndex;
            if (ComboBoxAlcoholic.SelectedIndex == 0)
            {
                drink.Alcoholic = true;
            }
            else { drink.Alcoholic = false; }
            drink.Price = float.Parse(txtDrinkPrice.Text);
            drinkDao.DeleteExistingDrink(drink);
            MessageBox.Show($"{drink.Name} succesfully deleted.");
        }

        private void btnSaveNewDrink_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkDao drinkDao = new DrinkDao();
                Drink drink = new Drink();
                drink.Name = txtNewName.Text;
                drink.StockAmount = (int)numNewStock.Value;
                //the drinks are: new drink, existing drinks
                drink.Id = DrinkSelectBox.Items.Count;
                if (ComboBoxNewAlcoholic.SelectedIndex == 0)
                {
                    drink.Alcoholic = true;
                }
                else { drink.Alcoholic = false; }
                drink.Price = float.Parse(txtNewPrice.Text);
                drinkDao.SaveNewDrink(drink);
                MessageBox.Show("New drink succesfully created.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred, likely due to missing a field: " + ex.Message);
            }
        }
    }
}
