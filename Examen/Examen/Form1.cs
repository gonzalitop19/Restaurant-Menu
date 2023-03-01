using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Tipo boolean para los check
        Boolean Western;
        Boolean Double;
        Boolean Super;
        Boolean Famous;
        Boolean papas;
        Boolean nieve;
        Boolean soda;
        double subtotal;
        double wes, sup, fam, dou, p, s, n;
        double totaltotal;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Papas_CheckedChanged(object sender, EventArgs e)
        {
            papas = Convert.ToBoolean(Papas.Checked);
            if (Papas.Checked)
                p =  45;
        }

        private void WesternBox3_CheckedChanged(object sender, EventArgs e)
        {
            Western = Convert.ToBoolean(WesternBox3.Checked);
            if (WesternBox3.Checked)
                wes = 220;
        }

        private void doublewestBox1_CheckedChanged(object sender, EventArgs e)
        {
            Double = Convert.ToBoolean(doublewestBox1.Checked);
            if (doublewestBox1.Checked)
                dou = 250;
        }

        private void SuperBox4_CheckedChanged(object sender, EventArgs e)
        {
            Super = Convert.ToBoolean(SuperBox4.Checked);
            if (SuperBox4.Checked)
                sup = 230;

        }

        private void FamousBox2_CheckedChanged(object sender, EventArgs e)
        {
            Famous = Convert.ToBoolean(FamousBox2.Checked);
            if (FamousBox2.Checked)
                fam = 227;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nieve_CheckedChanged(object sender, EventArgs e)
        {
            nieve = Convert.ToBoolean(Nieve.Checked);
            if (Nieve.Checked)
                n =  35;
        }

        private void Soda_CheckedChanged(object sender, EventArgs e)
        {
            soda = Convert.ToBoolean(Soda.Checked);
            if (Soda.Checked)
                s =  40;
        }


        private void Fin_Click(object sender, EventArgs e)
        {
            totaltotal = wes + dou + sup + fam + s + p + n;
            string total = totaltotal.ToString();
            TotalBox1.Text ='$' + totaltotal.ToString();

        }

        private void nuevopedido_Click(object sender, EventArgs e)
        {
            TotalBox1.Clear();
            WesternBox3.Checked = false;
            doublewestBox1.Checked= false;
            Nieve.Checked = false;
            Soda.Checked = false;
            SuperBox4.Checked = false;
            FamousBox2.Checked = false;
            Papas.Checked = false;
            Nieve.Checked = false;  

        }

        private void TotalBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
