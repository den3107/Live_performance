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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.ValidateUser(EmailTextBox.Text, PasswordTextBox.Text);
                if (user != null && !user.IsAdmin)
                {

                    this.Hide();
                    new MainForm(user, this).Show();
                }
                else if (user != null && user.IsAdmin)
                {
                    // TODO: open admin form
                    MessageBox.Show("Het administratiesysteem is nog niet geïmplementeerd.");
                }
            }
            catch (LoginFailedException)
            {
                MessageBox.Show("Uw e-mailadres of wachtwoord klopt niet.");
            }
        }
    }
}
