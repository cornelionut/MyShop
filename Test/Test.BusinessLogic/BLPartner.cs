using MyShop.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BusinessLogic
{
    public class BLPartner
    {
        public List<BLPartner>partnerInfoList = new List<BLPartner>();
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerSurname { get; set; }
        public string PartnerCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public BLPartner()
        {

        }

        public BLPartner(int partnerId, string partnerName, string partnerSurname, string partnerCode,
            string phoneNo, string email)
        {
            PartnerId = partnerId;
            PartnerName = partnerName;
            PartnerSurname = partnerSurname;
            PartnerCode = partnerCode;
            PhoneNo = phoneNo;
            Email = email;
        }

        public BLPartner(List<BLPartner> partnerInfoList)
        {
            this.partnerInfoList = partnerInfoList;
        }


        public List<BLPartner> loadDataPartner()
        {
            DAPartner dp = new DAPartner();
            DataSet set = dp.umpleDataGridView();

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                PartnerId = Convert.ToInt32(set.Tables[0].Rows[i]["PartnerId"].ToString());
                PartnerName = set.Tables[0].Rows[i]["PartnerName"].ToString();
                PartnerSurname = set.Tables[0].Rows[i]["PartnerSurname"].ToString();
                PartnerCode = set.Tables[0].Rows[i]["PartnerCode"].ToString();
                PhoneNo = set.Tables[0].Rows[i]["PhoneNo"].ToString();
                Email = set.Tables[0].Rows[i]["Email"].ToString();

                BLPartner p = new BLPartner(PartnerId, PartnerName, PartnerSurname, PartnerCode
                    , PhoneNo, Email);
                partnerInfoList.Add(p);
            }

            return partnerInfoList;
        }

        public List<BLPartner> loadFilteredDataPartner(string PartnerName,string PartnerCode)
        {
            DAPartner dp = new DAPartner();
            DataSet set = dp.umpleDataGridViewFiltrat(PartnerName,PartnerCode);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                PartnerId = Convert.ToInt32(set.Tables[0].Rows[i]["PartnerId"].ToString());
                PartnerName = set.Tables[0].Rows[i]["PartnerName"].ToString();
                PartnerSurname = set.Tables[0].Rows[i]["PartnerSurname"].ToString();
                PartnerCode = set.Tables[0].Rows[i]["PartnerCode"].ToString();
                PhoneNo = set.Tables[0].Rows[i]["PhoneNo"].ToString();
                Email = set.Tables[0].Rows[i]["Email"].ToString();

                BLPartner p = new BLPartner(PartnerId, PartnerName, PartnerSurname, PartnerCode
                    , PhoneNo, Email);
                partnerInfoList.Add(p);
            }

            return partnerInfoList;
        }


    }
}


