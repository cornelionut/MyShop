using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.BusinessLogic
{
    public class Partner
    {

        public List<Partner> partnerInfoList = new List<Partner>();
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerSurname { get; set; }
        public string PartnerCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public Partner()
        {

        }

        public Partner(int partnerId, string partnerName, string partnerSurname, string partnerCode,
            string phoneNo, string email)
        {
            PartnerId = partnerId;
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
            PartnerCode = partnerCode;
            PhoneNo = phoneNo;
            Email = email;
        }

        public Partner(string partnerName, string partnerSurname, string partnerCode,
           string phoneNo, string email)
        {
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
            PartnerCode = partnerCode;
            PhoneNo = phoneNo;
            Email = email;
        }

        public Partner(List<Partner> partnerInfoList)
        {
            this.partnerInfoList = partnerInfoList;
        }

        public bool AddToDatabase()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Resources.MySqlConnection);
                SqlCommand cmd = new SqlCommand("dbo.TPartner_AddPartner", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                cmd.Parameters.Add("@PartnerName", SqlDbType.VarChar, 20).Value = PartnerName;
                cmd.Parameters.Add("@PartnerSurname", SqlDbType.VarChar, 8000).Value = PartnerSurname;
                cmd.Parameters.Add("@PartnerCode", SqlDbType.VarChar, 20).Value = PartnerCode;
                cmd.Parameters.Add("@PhoneNo", SqlDbType.VarChar, 8000).Value = PhoneNo;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (ex.Message.ToLower().Contains("pk_partner"))
                    MessageBox.Show("Aceast partener exista deja!" + "\r\n", "Exista Deja!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Eroare la conexiunea cu baza de date:" + "\r\n", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            MessageBox.Show("Partener " + PartnerName + " a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
