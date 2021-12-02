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
    public partial class DeleteS : Form
    {
        public DeleteS()
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
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `users`.`login` = @login", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Student deleted");
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
