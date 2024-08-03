using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ExtraP2
{
    class ContaBancoDAL
    {
        private static String strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDAulas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;
        private static OleDbDataReader res;
        private static OleDbDataAdapter adaptador;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }
        public static void desconecta()
        {
            conn.Close();
        }

        public static void criarLogin(ContaBanco umaConta)
        {
            String aux = "insert into TabLogin(usuario,senha) values (@usuario,@senha)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = umaConta.user;
            strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = umaConta.senha;
            strSQL.ExecuteNonQuery();
        }
        public static void criarConta(ContaBanco umaConta)
        {
            String aux = "insert into TabConta(id,usuario,valor,nome,cpf,telefone,sexo) values (@id,@usuario,@valor,@nome,@cpf,@telefone,@sexo)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@id", OleDbType.VarChar).Value = umaConta.id;
            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = umaConta.user;
            strSQL.Parameters.Add("@valor", OleDbType.VarChar).Value = umaConta.valor;
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umaConta.nome;
            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = umaConta.cpf;
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = umaConta.telefone;
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = umaConta.sexo;
            
            strSQL.ExecuteNonQuery();
        }
        public static void loginUser(ContaBanco umaConta)
        {
            String aux = "select * from TabLogin where usuario = @usuario";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = umaConta.user;

            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                // TabLogin - Adquirir Senha Para Comparação
                umaConta.senha = result.GetString(2);

                // TabConta - Adquirir Dados
                aux = "select * from TabConta where usuario = @usuario";
                strSQL = new OleDbCommand(aux, conn);

                strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = umaConta.user;

                result = strSQL.ExecuteReader();
                Erro.setErro(false);
                if (result.Read())
                {
                    umaConta.id = result["id"].ToString();
                    umaConta.valor = result.GetString(2);
                    umaConta.nome = result.GetString(3);
                    umaConta.cpf = result.GetString(4);
                    umaConta.telefone = result.GetString(5);
                    umaConta.sexo = result.GetString(6);
                }
                else
                {
                    Erro.setMsg("Usuario não encontrado.");
                }
            }
            else
            {
                Erro.setMsg("Usuario não encontrado.");
            }
        }
        public static string checkValorConta(ContaBanco umaConta)
        {
            // TabConta - Adquirir Dados
            String aux = "select valor from TabConta where id = @id";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@id", OleDbType.VarChar).Value = umaConta.id;
            result = strSQL.ExecuteReader();

            Erro.setErro(false);
            if (result.Read())
            {
               return result["valor"].ToString();
            }
            else
            {
                Erro.setMsg("Erro!");
                return "0";
            }
        }
        public static void updateValor(ContaBanco umaConta)
        {
            String aux = "UPDATE TabConta SET valor = @valor WHERE id = @id";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@valor", OleDbType.VarChar).Value = umaConta.valor;
            strSQL.Parameters.Add("@id", OleDbType.VarChar).Value = umaConta.id;
            strSQL.ExecuteNonQuery();
        }
        public static void getContaById(ContaBanco umaConta, string id)
        {
            String aux = "select * from TabConta where id = @id";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@id", OleDbType.VarChar).Value = id;

            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                umaConta.user = result.GetString(1);
                umaConta.valor = result.GetString(2);
                umaConta.nome = result.GetString(3);
                umaConta.cpf = result.GetString(4);
                umaConta.telefone = result.GetString(5);
                umaConta.sexo = result.GetString(6);
            }
            else
            {
                Erro.setMsg("Cadastro não encontrado.");
            }
        }
        public static DataTable getData(string id)
        {
            DataTable dt = new DataTable();
            String aux = "select id from TabConta where id <>" + id;

            adaptador = new OleDbDataAdapter(aux, conn);
            adaptador.Fill(dt);
            adaptador.Dispose();

            return dt;
        }
        // Part Extrato
        public static void registroExtrato(ContaBanco umaConta, string flag, string contaDestino)
        {
            String aux = "insert into TabRegistro(tipo,contaOrigem,contaDestino,valor,dataHora) values (@tipo,@conta,@contaDestino,@valor,@dataHora)";
            string tipo = (flag == "s") ? "SAQUE" : (flag == "d") ? "DEPOSITO" : "TRANSFERENCIA";
            
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@tipo", OleDbType.VarChar).Value = tipo; // Tipo de Transação
            strSQL.Parameters.Add("@conta", OleDbType.VarChar).Value = umaConta.id; // Numero de Conta Origem

            if (flag == "t")
                strSQL.Parameters.Add("@contaDestino", OleDbType.VarChar).Value = contaDestino; // Numero de Conta Destino
            else
                strSQL.Parameters.Add("@contaDestino", OleDbType.VarChar).Value = "NONE"; // NULL caso não seja Transferencia

            strSQL.Parameters.Add("@valor", OleDbType.VarChar).Value = umaConta.valor; // Valor na transação
            strSQL.Parameters.Add("dataHora", OleDbType.Date).Value = DateTime.Now;

            strSQL.ExecuteNonQuery();
        }
        
        public static void populaExtratoDoc(string contaOrigem)
        {
            String aux = "select * from TabRegistro where ContaOrigem = @contaOrigem order by dataHora DESC";
            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@contaOrigem", OleDbType.VarChar).Value = contaOrigem;
            
            res = strSQL.ExecuteReader();
        }

        public static void getProximo()
        {
            Erro.setErro(false);
            if (res.Read())
            {
                Registro.setTipo(res.GetString(1));
                Registro.setContaOrigem(res.GetString(2));
                Registro.setContaDestino(res.GetString(3));
                Registro.setValor(res.GetString(4));
                Registro.setDataHoraReg(res.GetDateTime(5));
            }
            else
            {
                Erro.setErro(true);
            }
                
        }
    }
    
}
