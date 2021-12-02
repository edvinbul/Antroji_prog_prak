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
    public partial class DeleteO : Form
    {
        public DeleteO()
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

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `object` WHERE `object`.`object_name` = @object", db.GetConnection());

            command.Parameters.Add("@object", MySqlDbType.VarChar).Value = textBox1.Text;


            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Object deleted");
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
