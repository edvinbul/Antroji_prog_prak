﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Antroji_prog_prak
{
    public partial class LectorReg : Form
    {
       
        public LectorReg()
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
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter data");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `lectors` (`login`, `password`, `name`, `surname`, `object_name`) VALUES(@login, @password, @name, @surname, @object)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@object", MySqlDbType.VarChar).Value = textBox5.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Lector created");
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
