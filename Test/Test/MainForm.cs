using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Program.LoginForm.Close();
        }


        private void btnClienti_Click(object sender, EventArgs e)
        {
            frmClienti fc = new frmClienti();
           
            fc.Show();
       //     this.Close();

        }
    }
}
