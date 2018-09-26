using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop.DataAccess
{
   public class DAPartner
    {
        public DataSet umpleDataGridView()
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.MainSQLConnection);
            try
            {
                connection.Open();
                SqlCommand com = new SqlCommand("Select * from TPartner", connection);

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com);
                sqlDataAdapter.Fill(ds);
             
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataSet umpleDataGridViewFiltrat(string PartnerName,string PartnerCode)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.MainSQLConnection);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from TPartner where PartnerName=@PartnerName or PartnerCode=@PartnerCode  ", connection);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@PartnerName";
                parameter.DbType = DbType.String;
                parameter.Size = 512;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = PartnerName;

                SqlParameter parameterPC = new SqlParameter();
                parameterPC.ParameterName = "@PartnerCode";
                parameterPC.DbType = DbType.String;
                parameterPC.Size = 512;
                parameterPC.Direction = ParameterDirection.Input;
                parameterPC.Value = PartnerCode;

                command.Parameters.Add(parameter);
                command.Parameters.Add(parameterPC);

                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
