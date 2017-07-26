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

        public int DeleteUser(UserInfo objUserInfo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from UserInfo where UserNo = {0}");

            string sql = string.Format(sqlBuilder.ToString(), objUserInfo.UserNo);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public UserInfo GetUserByOrderNo(string orderNo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "select * from UserInfo inner join Orders on Orders.UserNo = UserInfo.UserNo where Orders.OrderNo = {0} ");

            string sql = string.Format(sqlBuilder.ToString(), orderNo);

            try
            {
                SqlDataReader objReaders = SQLHelper.GetObjectCollection(sql);
                UserInfo objUserInfo = new UserInfo();
                while (objReaders.Read())
                {
                    objUserInfo.UserNo = Convert.ToInt32(objReaders["UserNo"]);
                    objUserInfo.UserName = objReaders["UserName"].ToString();
                    objUserInfo.PhoneNumber = objReaders["PhoneNumber"].ToString();
                    objUserInfo.Address = objReaders["UserAddress"].ToString();
                    objUserInfo.CardNo = objReaders["CardNo"].ToString();

                }
                return objUserInfo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int UpdatetUser(UserInfo objUserInfo)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append(
                "update UserInfo set UserName='{0}', PhoneNumber='{1}', UserAddress='{2}', CardNo='{3}' where UserNo={4}");

            string sql = string.Format(sqlBuilder.ToString(), objUserInfo.UserName,
                objUserInfo.PhoneNumber, objUserInfo.Address, objUserInfo.CardNo, objUserInfo.UserNo);

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
    }
}
