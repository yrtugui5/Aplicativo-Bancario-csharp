using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraP2
{
    public partial class FormSaque : Form
    {
        ContaBanco contaSaque = new ContaBanco();
        public FormSaque(ContaBanco umaConta)
        {
            InitializeComponent();
            contaSaque = umaConta;
            txtValorSaque.Focus();

        }
        private void FormSaque_Load(object sender, EventArgs e)
        {
            lblSaqueInfoNome.Text = "Nome: " + contaSaque.nome;
            lblSaqueInfoConta.Text = "Conta Bancaria: " + contaSaque.id;
            lblSaldo.Text = "Saldo: " + float.Parse(contaSaque.valor).ToString("F2");
        }

        private void timerUpdateValor_Tick(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: " + float.Parse(ContaBancoDAL.checkValorConta(contaSaque)).ToString("F2");
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            ContaBancoBLL.validaField(txtValorSaque.Text);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                float valorSaque = float.Parse(txtValorSaque.Text);

                if(float.Parse(contaSaque.valor) < valorSaque)
                {
                    MessageBox.Show("O Saldo na Conta é insuficiente para efetuar esse Saque.");
                }
                else
                {
                    contaSaque.valor = (float.Parse(contaSaque.valor) - valorSaque).ToString();
                    ContaBancoDAL.updateValor(contaSaque);
                    DialogResult dialogResult = MessageBox.Show("Saque efetuado com Sucesso.\nDeseja Efetuar outro Saque?", "Saque Efetuado com Sucesso", MessageBoxButtons.YesNo);

                    ContaBancoDAL.registroExtrato(contaSaque, "s", ""); // Insert TabRegistros para Extratos Form

                    if (dialogResult == DialogResult.Yes)
                    {
                        txtValorSaque.Clear();
                        txtValorSaque.Focus();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                }
            }
        }
        private void OnlyNumber_KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
