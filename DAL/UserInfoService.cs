using DLL.Helper;
using Models;
using System;
using System.Data.SqlClient;
using System.Text;

namespace DLL
{
    public class UserInfoService
    {

        public int InsertUser(UserInfo objUserInfo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "insert into UserInfo (UserName, PhoneNumber, UserAddress, CardNo, CreateTime) values('{0}', '{1}', '{2}', '{3}', '{4}')");

            string sql = string.Format(sqlBuilder.ToString(), objUserInfo.UserName,
                objUserInfo.PhoneNumber, objUserInfo.Address, objUserInfo.CardNo, DateTime.Now.Date);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }


        public int GetLatestUserNo()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select count(*) from UserInfo");

            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleObject(sqlBuilder.ToString()));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
