using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Antroji_prog_prak
{
    public partial class Forlector : Form
    {
        
        Thread th7;
        public static string log;
        

        public Forlector()
        {
          
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String pass = textBox2.Text;
        

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `lectors` WHERE `login` = @Lo AND `password` = @Pa", db.GetConnection());
            command.Parameters.Add("@Lo", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@Pa", MySqlDbType.VarChar).Value = pass;
            
            Forlector.log = login;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You successfully logged in");
                this.Close();
                th7 = new Thread(opennewform5);
                th7.SetApartmentState(ApartmentState.STA);
                th7.Start();
            }

            else
            {
                MessageBox.Show("Fault");
            }

        }
        private void opennewform5(object obj)
        {
            Application.Run(new Lector());

        }
    }
}
