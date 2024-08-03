using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ExtraP2
{
    class ContaBancoBLL
    {
        public static void conecta()
        {
            // Conecta Banco de Dados
            ContaBancoDAL.conecta();
        }

        public static void desconecta()
        {
            // Desconta Banco de Dados
            ContaBancoDAL.desconecta();
        }

        public static void validaLogin(ContaBanco umaConta)
        {
            Erro.setErro(false);
            if (umaConta.user.Equals(""))
            {
                Erro.setMsg("O Campo Usuario é de preenchimento obrigatório!");
                return;
            }
            // Compara os Dados do Form com o do BD
            ContaBancoDAL.loginUser(umaConta);
        }
        public static void validaField(string inputField)
        {
            Erro.setErro(false);
            if (inputField.Equals(""))
            {
                Erro.setMsg("Campos Vazios Identificados, favor preenche-los!");
                return;
            }
        }

        public static void validaDados(ContaBanco umaConta)
        {
            Erro.setErro(false);
            if (umaConta.nome.Equals(""))
            {
                Erro.setMsg("O Campo Nome é de preenchimento obrigatório!");
                return;
            }
            if (umaConta.cpf.Length != 11)
            {
                Erro.setMsg("O CPF é Inválido!");
                return;
            }
            if (umaConta.cpf.Equals(""))
            {
                Erro.setMsg("O Campo CPF é de preenchimento obrigatório!");
                return;
            }
            if (umaConta.telefone.Length < 10 || umaConta.telefone.Length > 11)
            {
                Erro.setMsg("O Campo Telefone esta em formato incorreto!");
                return;
            }
            if (umaConta.telefone.Equals(""))
            {
                Erro.setMsg("O Campo Telefone é de preenchimento obrigatório!");
                return;
            }
            if (umaConta.user.Equals(""))
            {
                Erro.setMsg("O Campo Usuario é de preenchimento obrigatório!");
                return;
            }
            if (umaConta.senha.Equals(""))
            {
                Erro.setMsg("O Campo Senha é de preenchimento obrigatório!");
                return;
            }
            if (umaConta.sexo.Equals(""))
            {
                Erro.setMsg("O Campo Sexo é de preenchimento obrigatório!");
                return;
            }
            // Adiciona os Campos de Login ao BD_Login e os Campos Bancarios ao BD_Banco
            if (umaConta.verificaCPF(umaConta.cpf))
            {
                ContaBancoDAL.criarLogin(umaConta);
                ContaBancoDAL.criarConta(umaConta);
            }
            else
            {
                Erro.setMsg("O Campo CPF é de preenchimento obrigatório!");
                return;
            }

        }
        public static DataTable getDT(string conta)
        {
            return ContaBancoDAL.getData(conta);
        }
    }
}
