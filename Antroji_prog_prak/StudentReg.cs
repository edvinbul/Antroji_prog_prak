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

namespace Antroji_prog_prak
{
    public partial class StudentReg : Form
    {
        public StudentReg()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter data");
                    return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`, `group_number`) VALUES (@login, @password, @name, @surname, @group)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = textBox5.Text;

            db.openConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fault");
            }
            

            db.closeConnection();

        }

        private void StudentReg_Load(object sender, EventArgs e)
        {

        }
    }
}
