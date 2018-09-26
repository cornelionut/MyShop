using MyShop.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BusinessLogic
{
    public class BLAuthentification
    {
        public static string Decrypt(string Data)
        {
            try
            {
                byte[] dEC_data = Convert.FromBase64String(Data);
                string dEC_Str = ASCIIEncoding.ASCII.GetString(dEC_data);
                return dEC_Str;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


            public bool BLCheckUserLogin(string userName, string password)
        {
            bool status = false;
            DAAuthentification da = new DAAuthentification();
            DataSet set = da.DACheckUserLogin(userName);


            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {          
                if (password == Decrypt(set.Tables[0].Rows[i]["Password"].ToString()))
                {
                    status = true;
                    break;
                }
            }
            return status;
        }
    }
}
