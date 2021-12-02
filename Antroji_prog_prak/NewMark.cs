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
    public partial class NewMark : Form
    {
        public NewMark()
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
            MySqlCommand command = new MySqlCommand("INSERT INTO `marks` (`student_id`, `object_name`, `mark_value`) VALUES (@id, @ob, @mark)", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@ob", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@mark", MySqlDbType.VarChar).Value = textBox3.Text;
            

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Mark added");
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
