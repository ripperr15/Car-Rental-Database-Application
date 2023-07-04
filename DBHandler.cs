
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    public class DBHandler
    {
        
        private static String GetConnectionString()
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string connString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName={0}\CarRental.mdf;Integrated Security=True", strWorkPath);
            return connString;
        }

    public static DataTable GetCarsData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                
                adapter.Fill(dt);
                conn.Close();
                return dt;
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
                return dt;
            }
        }

        public static bool isUserExist(string query)
        {
            bool flag = false;
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader =  cmd.ExecuteReader();
                while (reader.Read())
                {
                    int count = reader.GetInt32("usercount");
                    flag = count == 0 ? false : true;
                }

                conn.Close();
                return flag;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
                return flag;
            }
        }

        public static int GetUserId(string query)
        {
            int id = 0;
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                }

                conn.Close();
                return id;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
                return id;
            }
        }

        public static void CreateUser(String query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
            }
        }
        
        public static void CreateBooking(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
            }
        }

        public static void UpdateStock(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(GetConnectionString());
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong when trying to connect to DB");
            }
        }
    }
}
