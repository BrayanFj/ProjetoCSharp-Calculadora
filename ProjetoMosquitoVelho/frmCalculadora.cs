using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        //limparCampos
        public void LimparCampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResposta.Text = "";
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbdividir.Checked = false;
            txtValor1.Focus();
        }



            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                double num1;
                double num2;
                double resp = 0;

                num1 = Convert.ToDouble(txtValor1.Text);
                num2 = Convert.ToDouble(txtValor2.Text);

                //instaciar a classe/objeto
                Operacoes op = new Operacoes();
                if (rdbSomar.Checked)
                {
                    resp = op.somaValor(num1, num2);
                }

                if (rdbSubtrair.Checked)
                {
                    resp = op.SubtrairValor(num1, num2);
                }

                if (rdbMultiplicar.Checked)
                {
                    resp = op.MultiplicarValor(num1, num2);
                }

                if (rdbdividir.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir por 0", "SistemaABC", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        //executar o metodo limparCampos
                        LimparCampos();

                    }
                    else
                    {
                        resp = op.DividirValor(num1, num2);
                    }
                }

                lblResposta.Text = resp.ToString();

            }

            private void btnLimpar_Click(object sender, EventArgs e)
            {
            LimparCampos();
            }

            private void btnSair_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }

