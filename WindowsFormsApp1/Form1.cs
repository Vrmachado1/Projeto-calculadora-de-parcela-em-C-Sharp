using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPagamento.Items.Add("A vista");
            cboPagamento.Items.Add("2x");
            cboPagamento.Items.Add("3x");
            cboPagamento.Items.Add("4x");
            cboPagamento.Items.Add("5x");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float vg, vp;
            vg = float.Parse(txtValorGasto.Text);
            if(cboPagamento.Text=="A vista")
            {
                vp = vg;
            }
            else if (cboPagamento.Text == "2x")
            {
                vp = vg / 2;
            }
            else if (cboPagamento.Text == "3x")
            {
                vp = vg / 3;
            }
            else if (cboPagamento.Text == "4x")
            {
                vp = vg / 4;
            }
            else
            {
                vp = vg / 5;
            }
            txtParcela.Text = vp.ToString();
        }
    }
}
