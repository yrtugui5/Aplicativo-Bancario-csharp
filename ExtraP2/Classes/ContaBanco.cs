using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExtraP2
{
    public class ContaBanco
    {
        // Campos Login
        public string user { get; set; }
        public string senha { get; set; }

        // Campos Bancarios
        public string id { get; set; } // Numero de Conta a ser Reconhecido para Transferencia
        public string valor { get; set; } // Valor Monetario a ser Incrementado ou Decrementado

        // Campos Pessoais
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }

        // Metodos
        public string cryptoSenha(string pw)
        {
            byte[] bytesDaSenha = Encoding.UTF8.GetBytes(pw); // converte a senha em um array de bytes
            SHA256 sha256 = new SHA256Managed();
            byte[] hash = sha256.ComputeHash(bytesDaSenha); // calcula o hash da senha

            string CryptPW = BitConverter.ToString(hash).Replace("-", String.Empty); // converte o hash em uma string hexadecimal
            return CryptPW;
        }
        public bool verificaCPF(string cpf)
        {
            string[] cpfs =
                {"00000000000",
                 "11111111111",
                 "22222222222",
                 "33333333333",
                 "44444444444",
                 "55555555555",
                 "66666666666",
                 "77777777777",
                 "88888888888",
                 "99999999999" };
            if (cpfs.Contains(cpf)){ return false; }
            int soma = 0, dig;
            char[] tempCPF = cpf.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                soma += (int.Parse(tempCPF[i].ToString()) * (10 - i));
            }
            dig = ((11 - (soma % 11)) >= 10) ? 0 : (11 - (soma % 11));
            if(dig == int.Parse(tempCPF[9].ToString())) 
            {
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += (int.Parse(tempCPF[i].ToString()) * (11 - i));
                }
                dig = ((11 - (soma % 11)) >= 10) ? 0 : (11 - (soma % 11));
                if (dig == int.Parse(tempCPF[10].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
