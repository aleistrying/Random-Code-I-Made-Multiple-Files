using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuickTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                string commandtext = "SELECT * FROM datos.laminadostable";
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=datos";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(commandtext, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandtext, con);
                command.CommandTimeout = 60;
                //MySqlDataReader reader = command.ExecuteReader;


                command.CommandText = "";
                try
                {
                    con.Open();
                    Console.WriteLine("sucessfully connected to server");
                    Console.WriteLine(con.DataSource);
                    con.Close();
                    Console.ReadLine();
            }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
