using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int valorInicial = int.Parse(valorA.Text);
                int fim = int.Parse(valorN.Text);
                int montante = 0;
                for (int i = 1; i<=fim; i++)
                {
                    montante = montante + valorInicial;
                    valorInicial++;
                }
                resultado.Text = "O montante da soma é: " + montante.ToString();
            } catch (Exception ex) {
                msgError.Visible = true;
                msgError.Text = "Ops, algo deu errado. \nErro:" + ex.Message;
            }
        }
    }
}
