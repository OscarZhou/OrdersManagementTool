using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DLL.Helper
{
    class SQLHelper
    {

        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        public static object GetSingleObject(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static SqlDataReader GetObjectCollection(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


    }
}
