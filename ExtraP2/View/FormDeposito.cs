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
    public partial class FormDeposito : Form
    {
        ContaBanco contaBancoDepo = new ContaBanco();
        public FormDeposito(ContaBanco umaConta)
        {
            InitializeComponent();
            contaBancoDepo = umaConta;
            txtValorDeposito.Focus();

        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {
            lblDepoInfoNome.Text = "Nome: " + contaBancoDepo.nome;
            lblDepoInfoConta.Text = "Conta Bancaria: " + contaBancoDepo.id;
            lblSaldo.Text = "Saldo: " + float.Parse(contaBancoDepo.valor).ToString("F2");
        }

        private void updateValorTimer_Tick(object sender, EventArgs e)
        {
            lblSaldo.Text = "Saldo: " + float.Parse(ContaBancoDAL.checkValorConta(contaBancoDepo)).ToString("F2");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ContaBancoBLL.validaField(txtValorDeposito.Text);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                float valorDeposito = float.Parse(txtValorDeposito.Text);
                contaBancoDepo.valor = (float.Parse(contaBancoDepo.valor) + valorDeposito).ToString();
                ContaBancoDAL.updateValor(contaBancoDepo);
                DialogResult dialogResult = MessageBox.Show("Depósito efetuado com Sucesso.\nDeseja Efetuar outro Depósito ?", "Depósito Efetuado com Sucesso", MessageBoxButtons.YesNo);

                ContaBancoDAL.registroExtrato(contaBancoDepo, "d", ""); // Insert TabRegistros para Extratos Form

                if (dialogResult == DialogResult.Yes)
                {
                    txtValorDeposito.Clear();
                    txtValorDeposito.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
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
