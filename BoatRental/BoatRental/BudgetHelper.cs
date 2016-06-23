using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatRental.Types;
using BoatRental.Exceptions;

namespace BoatRental
{
    public partial class BudgetHelper : Form
    {
        double budgetLeft = 0;
        int friescheLakes = 0;

        public BudgetHelper()
        {
            InitializeComponent();

            foreach (Lake lake in Lake.GetAllLakes())
            {
                LakesListBox.Items.Add(lake);
            }
            foreach (Boat boat in Boat.GetAllBoats())
            {
                BoatsListBox.Items.Add(boat);
            }
            foreach (Item item in Item.GetAllItems())
            {
                ItemsListBox.Items.Add(item);
            }
        }

        private void LakesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LakesListBox.SelectedItem != null)
            {
                LakePriceLabel.Text = "€" + ((Lake) LakesListBox.SelectedItem).Price;
            }
            else
            {
                LakePriceLabel.Text = "";
            }
        }

        private void AddLakeButton_Click(object sender, EventArgs e)
        {
            Lake lake = LakesListBox.SelectedItem as Lake;
            if (lake != null)
            {
                LakesListBox.Items.Remove(lake);
                ChosenLakesListBox.Items.Add(lake);
            }
        }

        private void DeleteLakeButton_Click(object sender, EventArgs e)
        {
            Lake lake = ChosenLakesListBox.SelectedItem as Lake;
            if (lake != null)
            {
                ChosenLakesListBox.Items.Remove(lake);
                LakesListBox.Items.Add(lake);

            }
        }

        private void BoatsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoatsListBox.SelectedItem != null)
            {
                BoatPriceLabel.Text = "€" + ((Boat) BoatsListBox.SelectedItem).Motor.Price;
                MotorNameLabel.Text = ((Boat) BoatsListBox.SelectedItem).Motor.Name;
                if (((Boat) BoatsListBox.SelectedItem).Motor.TankCapacity > 0)
                {
                    ActionRadiusLabel.Text = ((Boat) BoatsListBox.SelectedItem).Motor.TankCapacity * 15 + "km";
                }
                else
                {
                    ActionRadiusLabel.Text = "N.V.T.";
                }
                MayTraverseLakes.Visible = ((Boat) BoatsListBox.SelectedItem).Motor.MayTraverseLakes;
                PaysLockLabel.Visible = !((Boat) BoatsListBox.SelectedItem).Kind.PaysForLock;
            }
            else
            {
                BoatPriceLabel.Text = "";
                MotorNameLabel.Text = "";
                ActionRadiusLabel.Text = "";
                MayTraverseLakes.Visible = false;
                PaysLockLabel.Visible = false;
            }
        }

        private void AddBoatButton_Click(object sender, EventArgs e)
        {
            Boat boat = BoatsListBox.SelectedItem as Boat;
            if (boat != null)
            {
                BoatsListBox.Items.Remove(boat);
                ChosenBoatsListBox.Items.Add(boat);
            }
        }

        private void DeleteBoatButton_Click(object sender, EventArgs e)
        {
            Boat boat = ChosenBoatsListBox.SelectedItem as Boat;
            if (boat != null)
            {
                ChosenBoatsListBox.Items.Remove(boat);
                BoatsListBox.Items.Add(boat);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                ItemPriceLabel.Text = "€" + ((Item) ItemsListBox.SelectedItem).Price;
            }
            else
            {
                ItemPriceLabel.Text = "";
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = ItemsListBox.SelectedItem as Item;
            if (item != null)
            {
                ChosenItemsListBox.Items.Add(item);
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            Item item = ChosenItemsListBox.SelectedItem as Item;
            if (item != null)
            {
                ChosenItemsListBox.Items.Remove(item);
            }
        }

        private void CalculateBudgetButton_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateBudget();
                BudgetLabel.Text = "Met dit budget kan u " + friescheLakes + " Friese meren bevaren en houdt u €" + budgetLeft + " over.";
            }
            catch (MakeContractException ex)
            {
                MessageBox.Show(ex.Message, "Er ging iets fout!");
            }
            catch (InsufficientBudget)
            {
                MessageBox.Show("Budget is te klein. U heeft tenminste €" + budgetLeft + " nodig om met dit contract één friesch meer te mogen bevaren.", "Er ging iets fout!");
            }
        }

        private void CalculateBudget()
        {
            if (StartDateTimePicker.Value.Date > EndDateTimePicker.Value.Date)
            {
                throw new MakeContractException("Einde datum moet na start datum zijn.");
            }

            if (ChosenBoatsListBox.Items.Count < 1)
            {
                throw new MakeContractException("Er moet op zijn minst één boot worden gehuurd.");
            }


            int days = (int) (EndDateTimePicker.Value - StartDateTimePicker.Value).TotalDays + 1;
            double price = 0;

            // Calculate minimal price
            List<Boat> boats = new List<Boat>();
            for (int i = 0; i < ChosenBoatsListBox.Items.Count; i++)
            {
                boats.Add(ChosenBoatsListBox.Items[i] as Boat);
                price += boats.Last().Motor.Price * days;
            }
            List<Item> items = new List<Item>();
            for (int i = 0; i < ChosenItemsListBox.Items.Count; i++)
            {
                items.Add(ChosenItemsListBox.Items[i] as Item);
                price += items.Last().Price * days;
            }
            List<Lake> lakes = new List<Lake>();
            for (int i = 0; i < ChosenLakesListBox.Items.Count; i++)
            {
                lakes.Add(ChosenLakesListBox.Items[i] as Lake);
                price += lakes.Last().Price;
            }

            // Budget is too small
            if (price > (double) BudgetNumericUpDown.Value)
            {
                budgetLeft = price + CONFIG.FrieschLakePrice;
                throw new InsufficientBudget();
            }

            // Check if budget is small enough so won't require locks
            if (price + CONFIG.FrieschLakePrice * CONFIG.MaxFrieschLakes > budgetLeft)
            {
                // Can safely calculate is now
                friescheLakes = (int) Math.Floor(((double) BudgetNumericUpDown.Value - price) / CONFIG.FrieschLakePrice);
                budgetLeft = (double) BudgetNumericUpDown.Value - (price + CONFIG.FrieschLakePrice * friescheLakes);
            }
            else
            {
                // Add the 5 
                price += CONFIG.FrieschLakePrice * CONFIG.MaxFrieschLakes;
                friescheLakes = CONFIG.MaxFrieschLakes;

                // Now calculate with taking locks in mind
                friescheLakes += (int) Math.Floor(((double) BudgetNumericUpDown.Value - price) / (CONFIG.FrieschLakePrice + CONFIG.LockPrice));
                budgetLeft = (double) BudgetNumericUpDown.Value - (price + (CONFIG.FrieschLakePrice + CONFIG.LockPrice) * (friescheLakes - CONFIG.MaxFrieschLakes));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
