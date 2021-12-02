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
    public partial class MarksCH : Form
    {
        public MarksCH()
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
            MySqlCommand command = new MySqlCommand("UPDATE `marks` SET `mark_value` = @number WHERE `marks`.`student_id` = @id AND `marks`.`object_name` = @nm", db.GetConnection());

            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = textBox1.Text;
          

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Mark has changed");
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
