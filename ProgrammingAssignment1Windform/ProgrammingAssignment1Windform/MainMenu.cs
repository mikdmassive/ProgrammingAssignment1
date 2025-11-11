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
    public partial class MainMenu : Form
    {
        static List<Match> Matches = new List<Match>();
        static User user = null;
        public MainMenu(User loginuser, List<Match> Matches)
        {
            user = loginuser;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                MainMenuGroupBox.Text = $"Welcome, {user.fname} {user.lname}!";
                Balance.Text = "Balance: £" + user.balance.ToString("0.00");
            }

        }
        private void PrepareGB(string txt)
        {
            UsedGroupBox.Controls.Clear();
            UsedGroupBox.Text = txt;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewBetsButton_Click(object sender, EventArgs e)
        {
            PrepareGB("View Bets");
        }

        private void ViewMatchesButton_Click(object sender, EventArgs e)
        {
            PrepareGB("View Matches");
        }

        private void PlaceBets_Click(object sender, EventArgs e)
        {
            PrepareGB("Place Bets");
        }
    }
}
