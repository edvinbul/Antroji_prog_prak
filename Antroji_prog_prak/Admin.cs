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
    public partial class Admin : Form
    {
        Thread th3;
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform6);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform6(object obj)
        {
            Application.Run(new StudentReg());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform7);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform7(object obj)
        {
            Application.Run(new DeleteS());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform8);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform8(object obj)
        {
            Application.Run(new LectorReg());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform9);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform9(object obj)
        {
            Application.Run(new DeleteL());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform10);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform10(object obj)
        {
            Application.Run(new ObjectReg());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform11);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform11(object obj)
        {
            Application.Run(new DeleteO());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform12);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform12(object obj)
        {
            Application.Run(new GroupReg());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform13);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
            this.Close();
        }
        private void opennewform13(object obj)
        {
            Application.Run(new Firstview());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform14);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform14(object obj)
        {
            Application.Run(new DeleteG());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform15);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform15(object obj)
        {
            Application.Run(new ChangeLO());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform16);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform16(object obj)
        {
            Application.Run(new ChangeSG());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            th3 = new Thread(opennewform17);
            th3.SetApartmentState(ApartmentState.STA);
            th3.Start();
        }
        private void opennewform17(object obj)
        {
            Application.Run(new ChangeOG());

        }
    }
}
