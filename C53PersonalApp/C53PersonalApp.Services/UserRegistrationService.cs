using C53PersonalApp.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C53PersonalApp.Services
{
    public class UserRegistrationService
    {
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
