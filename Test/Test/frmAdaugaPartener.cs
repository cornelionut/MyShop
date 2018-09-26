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
    public partial class frmAdaugaPartener : Form
    {
        public frmAdaugaPartener()
        {
            InitializeComponent();
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            try
            {
                string PartnerName = tbAddNumePartener.Text;
                string PartnerSurname = tbAddPrenumePartener.Text;
                string PartnerCode = tbAddCodPartener.Text;
                string PhoneNo = tbAddTelefonPartener.Text;
                string Email = tbAddMailPartener.Text;

                Partner p = new Partner(PartnerName, PartnerSurname, PartnerCode, PhoneNo, Email);

                if (p.AddToDatabase() == true)
                {
                    tbAddNumePartener.Text = "";
                    tbAddPrenumePartener.Text = "";
                    tbAddCodPartener.Text = "";
                    tbAddTelefonPartener.Text = "";
                    tbAddMailPartener.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
