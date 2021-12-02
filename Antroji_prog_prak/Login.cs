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
    public partial class Login : Form
    {
        Thread th1;
        public static string log1;
        public static string id1;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @log AND `pass` = @Pa", db.GetConnection());
            command.Parameters.Add("@Pa", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            Login.log1 = login;

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("You successfully logged in");
                this.Close();
                th1 = new Thread(opennewform18);
                th1.SetApartmentState(ApartmentState.STA);
                th1.Start();
            }
            else
            {
                MessageBox.Show("Fault");
            }

        }
        private void opennewform18(object obj)
        {
            Application.Run(new Student());

        }
    }
}
