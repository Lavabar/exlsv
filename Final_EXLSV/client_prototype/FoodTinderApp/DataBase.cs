using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTinderApp
{
    static class DataBase
    {
        static string connectionString = "server=sql11.freemysqlhosting.net;user=sql11228687;database=sql11228687;password=xsgxhgnjHb;";

        static MySqlConnection connection = new MySqlConnection(connectionString);
        static MySqlCommand command;
        static MySqlDataReader reader;
        static string sql = "";

        static public void openConnection()
        {
            connection.Open();
        }

        static public void closeConnection()
        {
            connection.Close();

        }

        static public void SendFirstQuery()
        {
            sql = "SELECT number,name,category FROM imgs";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                User.list_p2.Add(new Product()
                {
                    Number = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    typeOfProduct = Convert.ToInt32(reader[2])
                });
            }
        }

    }
}
