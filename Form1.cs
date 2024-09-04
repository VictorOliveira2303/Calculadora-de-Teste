using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Windows_Forms
{
    public partial class CalculadoraTeste1 : Form
    {
        public CalculadoraTeste1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Você realmente deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 0, resultado = 0;
            n1 = double.Parse(txtNum1.Text);
            n2 = double.Parse(txtNum2.Text);
            //se for Divisão
            if (CboTipoCalc.SelectedItem.ToString() == "Div")
            {
                resultado = n1 / n2;
            }
            else
            {

            }
            //Se for Soma
            if (CboTipoCalc.SelectedItem.ToString() == "Soma")
            {
                resultado = n1 + n2;
            }
            else
            {

            }
            //Se for Multiplicação
            if (CboTipoCalc.SelectedItem.ToString() == "Mult")
            {
                resultado = n1 * n2;
            }
            else
            {

            }
            //Se for Subtração
            if (CboTipoCalc.SelectedItem.ToString() == "Sub")
            {
                resultado = n1 - n2;
            }
            else
            {

            }
            LblResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            LblResultado.Text = ""; 
        }
    }
}