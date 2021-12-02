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
    public partial class Foradmin : Form
    {
        Thread th1;
        public Foradmin()
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `Login` = @Lo AND `Password` = @Pa", db.GetConnection());
            command.Parameters.Add("@Lo", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@Pa", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You successfully logged in");
                this.Close();
                th1 = new Thread(opennewform5);
                th1.SetApartmentState(ApartmentState.STA);
                th1.Start();
            }
            
            else
            {
                MessageBox.Show("Fault");
            }
            
        }
        private void opennewform5(object obj)
        {
            Application.Run(new Admin());

        }
    }
}
