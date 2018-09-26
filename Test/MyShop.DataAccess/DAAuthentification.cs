using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess
{
    public class DAAuthentification
    {
        SqlConnection connection = new SqlConnection(Properties.Resources.MainSQLConnection);

        public DataSet DACheckUserLogin(string userName)
        {    
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = " select UserId,UserName,Password from TERPUser where UserName = @UserName ";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = DbType.String;
                parameter.Size = 512;
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = userName;

                command.Parameters.Add(parameter);

                DataSet set = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(set);

                return set;
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



        //public DataSet DALoadPartners()
        //{
        //    try
        //    {

        //    }catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {

        //    }
        //}
    }
}
