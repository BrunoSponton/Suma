using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Prueba_4
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void Suma_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txt1.Text = "0";
            txt2.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            int nro1;
            int nro2;
            int resultado;

            nro1 = System.Convert.ToInt32(txt1.Text);
            nro2 = System.Convert.ToInt32(txt2.Text);
            resultado = nro1 + nro2;
            lblresultado.Text = System.Convert.ToString(resultado);
        }
    }
}
