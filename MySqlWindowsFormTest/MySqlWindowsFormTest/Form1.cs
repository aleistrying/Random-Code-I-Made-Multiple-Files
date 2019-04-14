using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlWindowsFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startMySqlServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Laminados_TextChanged(object sender, EventArgs e)
        {

        }
        private void startMySqlServer()
        {
            object[] objectArray = new object[6];
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();

            for (int i = 1; i <= 8; i++)
            {
                string Query = "SELECT * FROM  datos.laminadostable WHERE ID= " + i + " GROUP BY ID;";
                string stringConnection = "host=localHost;username=root;password=root;database=datos";
                MySqlConnection connection = new MySqlConnection(stringConnection);
                //MySqlDataAdapter adaptor = new MySqlDataAdapter(Query, connection);
                MySqlCommand command = new MySqlCommand(Query, connection);

                try
                {
                    connection.Open();
                   MySqlDataReader reader = command.ExecuteReader();
                    int x = 0;
                    if (reader.Read())
                    {
                        reader.GetValues(objectArray);

                            list1.Add(objectArray[1].ToString());
                            list2.Add(objectArray[2].ToString());
                            list3.Add(objectArray[3].ToString());
                            x++;
                    }
                    connection.Close();
                }
                catch(Exception e){ CostoUnitarioCreado.Text = e.ToString(); }
            }
            LaminadosCombox.Items.AddRange(list1.ToArray());
            GrosCombox.Items.AddRange(list2.ToArray());
            CostoCombox.Items.AddRange(list3.ToArray());
        }

        private void LaminadosCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
