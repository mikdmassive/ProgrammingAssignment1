using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment1Windform
{
    public partial class DepositForm : Form
    {
        static User user = null;
        public DepositForm(User userr)
        {
            user = userr;
            InitializeComponent();
        }
        public void UpdateStats(User userr)
        {
            user = userr;
            LoadedBox();
        }
        private void LoadedBox()
        {
            DepositGB.Text = $"{user.username} - Balance £{user.balance.ToString("0.00")}";
        }
        private void DepositForm_Load(object sender, EventArgs e)
        {
            LoadedBox();
        }
  
        private void msg(string txt)
        {
            ErrorMsg.Text = txt;
        }
        private void invalidDeposit(string txt)
        {
            DepositTextBox.Text = "";
            msg(txt);
        }
        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == user.password)
            {
                if (float.TryParse(DepositTextBox.Text, out float number))
                {
                    if (number > 0)
                    {
                        //todo deposit
                        PasswordTextBox.Text = "";
                        DepositTextBox.Text = "";
                        Program.Deposit(number);
                        msg($"Deposit of {number.ToString("0.00")} successful!");
                    }
                    else
                    {
                        invalidDeposit("Deposit cannot be negative");
                    }

                }
                else
                {
                    invalidDeposit("Only enter numbers (can be decimal)");
                }
            }
            else
            {
                PasswordTextBox.Text = "";
                msg("Incorrect Password");
            }
        }
       
        private void RemoveErrorMessage(object sender, EventArgs e)
        {
            msg("");
        }

    
    }
}
