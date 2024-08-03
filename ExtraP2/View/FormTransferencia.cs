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
    public partial class FormTransferencia : Form
    {
        ContaBanco minhaConta = new ContaBanco();
        ContaBanco contaTransferida = new ContaBanco();
        string contaDestino = "0";
       
        public FormTransferencia(ContaBanco umaConta)
        {
            InitializeComponent();
            minhaConta = umaConta;
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            string id = minhaConta.id;
            lblNomeMinhaConta.Text = "Nome: " + minhaConta.nome;
            lblCPFMinhaConta.Text = "CPF: " + Convert.ToUInt64(minhaConta.cpf).ToString(@"000\.000\.000\-00");
            lblContaMinhaConta.Text = "Conta Bancaria: " + id;
            lblValorMinhaConta.Text = "Saldo: " + float.Parse(minhaConta.valor).ToString("F2");
            DataTable tableContas = ContaBancoBLL.getDT(id);
            cbxContasDestino.DataSource = tableContas;
            cbxContasDestino.DisplayMember = "id";
            cbxContasDestino.Text = "Selecione a Conta Destino.";

        }

        private void timerUpdateValor_Tick(object sender, EventArgs e)
        {
            lblValorMinhaConta.Text = "Saldo: " + float.Parse(ContaBancoDAL.checkValorConta(minhaConta)).ToString("F2");
            if (cbxContasDestino.FindStringExact(contaDestino) > -1)
            {
                ContaBancoDAL.getContaById(contaTransferida, contaDestino);
                lblNomeContaDestino.Text = "Nome: " + contaTransferida.nome;
                lblCPFContaDestino.Text = "CPF: " + Convert.ToUInt64(contaTransferida.cpf).ToString(@"000\.000\.000\-00");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            
            ContaBancoBLL.validaField(contaDestino);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                if (cbxContasDestino.FindStringExact(contaDestino) > -1)
                {
                    float valorTransferencia = float.Parse(txtValorTransferencia.Text);
                    if (float.Parse(minhaConta.valor) < valorTransferencia)
                    {
                        MessageBox.Show("Valor da Transferencia é insuficiente para a transação.");
                        return;
                    }
                    else
                    {
                        minhaConta.valor = (float.Parse(minhaConta.valor) - valorTransferencia).ToString();
                        ContaBancoDAL.updateValor(minhaConta);

                        contaTransferida.id = contaDestino;
                        ContaBancoDAL.getContaById(contaTransferida, contaDestino);
                        contaTransferida.valor = (float.Parse(contaTransferida.valor) + valorTransferencia).ToString();
                        ContaBancoDAL.updateValor(contaTransferida);

                        string textTransferencia = ("Tranferencia de R$" + valorTransferencia.ToString("F2") + " para " + contaTransferida.nome + " foi Realizada.");
                        DialogResult dialogResult = MessageBox.Show(textTransferencia + "\nDeseja Efetuar outra Transferencia ?", "Transferencia Efetuada com Sucesso", MessageBoxButtons.YesNo);

                        ContaBancoDAL.registroExtrato(minhaConta, "t", contaDestino); // Insert TabRegistros para Extratos Form

                        if (dialogResult == DialogResult.Yes)
                        {
                            txtValorTransferencia.Clear();
                            txtValorTransferencia.Focus();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Erro! Conta Inexistente.");
                    FormTransferencia_Load(null, EventArgs.Empty);
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

        private void cbxContasDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            contaDestino = cbxContasDestino.GetItemText(cbxContasDestino.SelectedItem);
        }
    }
}
