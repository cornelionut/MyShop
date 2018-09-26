using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.BusinessLogic;

namespace Test
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbUser.Text) && !String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                BLAuthentification authentification = new BLAuthentification();
                bool status = authentification.BLCheckUserLogin(tbUser.Text, tbPassword.Text);
                if (status)
                {
                    MainForm f = new MainForm();
                    f.ShowDialog();
                    this.Close();
                   // Program.LoginForm.Close();
                }
                else
                    MessageBox.Show("Utilizator sau parola incorecte");
            }
            else
                MessageBox.Show("Utilizator sau parola nu sunt completate");

        }
    }
}
