using System;
using System.Windows.Forms;
using Test.BusinessLogic;

namespace Test
{
    public partial class frmClienti : Form
    {
        public frmClienti()
        {
            InitializeComponent();
            incarcaComboBox();
        }

        public void incarcaComboBox()
        {

        }

        private void btnCautaPartener_Click(object sender, EventArgs e)
        {
            BLPartner bp = new BLPartner();
            //  MessageBox.Show(bp.loadDataPartner().Count + "");

            if (String.IsNullOrWhiteSpace(cmbFilterPartnerName.Text) && String.IsNullOrWhiteSpace(tbFilterPartnerCode.Text))
            {
                dgClienti.DataSource = bp.loadDataPartner();
            }
            else if (!String.IsNullOrWhiteSpace(cmbFilterPartnerName.Text) && !!String.IsNullOrWhiteSpace(tbFilterPartnerCode.Text))
            {
                dgClienti.DataSource = bp.loadFilteredDataPartner(cmbFilterPartnerName.Text,tbFilterPartnerCode.Text);
            }


        }

        private void btnAdaugaPartener_Click(object sender, EventArgs e)
        {
            //  BLPartner bp = new BLPartner();
            //  bp.AdaugaPartner();
            frmAdaugaPartener ap = new frmAdaugaPartener();
            ap.Show();
            this.Close();

            //refresh
        }
    }
}
