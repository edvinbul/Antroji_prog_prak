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
    public partial class ChangeSG : Form
    {
        public ChangeSG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `group_number` = @number WHERE `users`.`name` = @name AND `users`.`surname` = @surname", db.GetConnection());

            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox2.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Group changed");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fault");
            }


            db.closeConnection();
        }
    }
}
