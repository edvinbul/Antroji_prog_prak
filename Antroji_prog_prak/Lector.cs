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
    public partial class Lector : Form
    {
        Thread th6;
        public Lector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lector_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            th6 = new Thread(opennewform17);
            th6.SetApartmentState(ApartmentState.STA);
            th6.Start();
        }
        private void opennewform17(object obj)
        {
            Application.Run(new MarksCH());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            th6 = new Thread(opennewform18);
            th6.SetApartmentState(ApartmentState.STA);
            th6.Start();
        }
        private void opennewform18(object obj)
        {
            Application.Run(new NewMark());

        }
    }
}
