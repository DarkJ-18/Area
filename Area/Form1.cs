using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double radio;
        Double area;
        Double circunferencia;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(txtradio.Text);
            area = Math.PI * radio * radio;
            lbltotal.Text = Convert.ToString("El área del circulo es: " + area);
        }
    }
}
