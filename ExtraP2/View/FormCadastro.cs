using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExtraP2
{
    public partial class FormCadastro : Form
    {
        Random rnd = new Random();
        ContaBanco umaConta = new ContaBanco();
        public FormCadastro()
        {
            InitializeComponent();
            rdnBtnM.Checked = true;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show("As Senhas não estão iguais.");
                Application.Exit();
            }
            else
            {
                umaConta.id = rnd.Next(10000,99999).ToString();
                umaConta.senha = umaConta.cryptoSenha(txtSenha.Text);
                umaConta.nome = txtNome.Text;
                umaConta.cpf = txtCPF.Text;
                umaConta.telefone = txtTelefone.Text;
                umaConta.sexo = (rdnBtnM.Checked) ? "M" : "F";
                umaConta.user = txtUsuario.Text;
                umaConta.valor = "0";

                ContaBancoBLL.validaDados(umaConta);
                if (Erro.getErro())
                    MessageBox.Show(Erro.getMsg());
                else
                {
                    MessageBox.Show("Conta Cadastrada com sucesso!");
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
