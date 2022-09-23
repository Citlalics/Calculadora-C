using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            //crear elobjeto y pasar valores al constructor 
            Sumac sum = new Sumac(double.Parse(txt1.Text), double.Parse(txt2.Text));
            //pasar valores 
            txt3.Text = sum.suma().ToString();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            Restac rest = new Restac(double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = rest.resta().ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            Multic mcion = new Multic(double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = mcion.multi().ToString();
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            Divic Dcion = new Divic(double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = Dcion.division().ToString();
        }
    }
}
