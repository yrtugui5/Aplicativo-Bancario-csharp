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
using System.Security.Cryptography;

namespace ExtraP2
{
    public partial class FormMain : Form
    {
        ContaBanco umaConta = new ContaBanco();
        float valorConta = 0;
        int flag = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Panel
            panelLogin.Enabled = true;
            // Desativa Elementos
            btnDeposito.Enabled = false;
            btnSaque.Enabled = false;
            btnTransferencia.Enabled = false;
            btnExtrato.Enabled = false;
            btnSair.Enabled = false;
            // Esconde Elementos
            lblValor.Visible = false;
            lblContaUsuario.Visible = false;
            lblUsuario.Visible = false;
            // Flag Setup
            flag = 0;
            // Conecta o Banco de Dados
            ContaBancoBLL.conecta();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Desconectar Banco de Dados
            ContaBancoBLL.desconecta();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            umaConta.user = txtUser.Text;
            ContaBancoBLL.validaLogin(umaConta);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                if((umaConta.user == txtUser.Text) && (umaConta.senha == umaConta.cryptoSenha(txtPassword.Text))) 
                {
                    MessageBox.Show("Acesso Garantido.");
                    flag = 1;

                    txtUser.Clear();
                    txtPassword.Clear();

                    lblUsuario.Text = "Nome: " + umaConta.nome + " | CPF: " + Convert.ToUInt64(umaConta.cpf).ToString(@"000\.000\.000\-00"); ;
                    lblContaUsuario.Text = "Conta: " + umaConta.id;
                    lblValor.Text = "Saldo: " + valorConta.ToString("F2");

                    lblValor.Visible = true;
                    lblContaUsuario.Visible = true;
                    lblUsuario.Visible = true;

                    btnDeposito.Enabled = true;
                    btnSaque.Enabled = true;
                    btnTransferencia.Enabled = true;
                    btnExtrato.Enabled = true;
                    btnSair.Enabled = true;

                    panelLogin.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Senha Incorreta.");
                }
            }
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString();
            if(flag == 1)
            {
                lblValor.Text = "Saldo: " + float.Parse(ContaBancoDAL.checkValorConta(umaConta)).ToString("F2");
            }
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form formCadastro = new FormCadastro();
            formCadastro.Show();
        }
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Form formDeposito = new FormDeposito(umaConta);
            formDeposito.Show();
        }
        private void btnSaque_Click(object sender, EventArgs e)
        {
            Form formSaque = new FormSaque(umaConta);
            formSaque.Show();
        }
        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Form formTransferencia = new FormTransferencia(umaConta);
            formTransferencia.Show();
        }
        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form formExtrato = new FormExtrato(umaConta);
            formExtrato.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FormMain_Load(null, EventArgs.Empty);
        }
    }
}
