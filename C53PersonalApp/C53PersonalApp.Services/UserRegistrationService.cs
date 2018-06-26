using C53PersonalApp.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C53PersonalApp.Services
{
    public class UserRegistrationService
    {
        private string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public int Insert(UserRegistrationAddRequest model)
        {
            int id = 0;
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string sqlCmd = "userRegistration_Insert";
                    using(SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter parm = new SqlParameter();
                        parm.SqlDbType = System.Data.SqlDbType.Int;
                        parm.Direction = System.Data.ParameterDirection.Output;
                        parm.ParameterName = "@Id";

                        cmd.Parameters.Add(parm);
                        cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", model.LastName);
                        cmd.Parameters.AddWithValue("@Email", model.Email);
                        cmd.Parameters.AddWithValue("@UserName", model.UserName);
                        cmd.Parameters.AddWithValue("@Password", model.Password);

                        cmd.ExecuteNonQuery();

                         id = (int)cmd.Parameters["@Id"].Value;
                    }
                }
                else
                {
                    Console.WriteLine("Oops!!! Something went wrong...");
                }
                conn.Close();
                return id;
            }
        }
        //public int Insert(UserRegistrationAddRequest model)
        //{
        //    int id = 0;

        //    this.DataProvider.ExecuteNonQuery(
        //        "userRegistration_Insert",
        //        inputParamMapper: delegate (SqlParameterCollection paramCol)
        //        {
        //            SqlParameter parm = new SqlParameter();
        //            parm.ParameterName = "@Id";
        //            parm.SqlDbType = System.Data.SqlDbType.Int;
        //            parm.Direction = System.Data.ParameterDirection.Output;
        //            paramCol.Add(parm);
        //            paramCol.AddWithValue("@FirstName", model.FirstName);
        //            paramCol.AddWithValue("@LastName", model.LastName);
        //            paramCol.AddWithValue("@Email", model.Email);
        //            paramCol.AddWithValue("@UserName", model.UserName);
        //            paramCol.AddWithValue("@Password", model.Password);
        //        },
        //        returnParameters: delegate (SqlParameterCollection paramCol)
        //        {
        //            id = (int)paramCol["@Id"].Value;
        //        }
        //    );
        //    return id;
        //}
    }
}
