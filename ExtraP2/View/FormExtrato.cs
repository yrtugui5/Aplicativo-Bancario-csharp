using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraP2
{
    public partial class FormExtrato : Form
    {
        ContaBanco minhaConta = new ContaBanco();
        int i = 0;
        int j = 1;
        public FormExtrato(ContaBanco umaConta)
        {
            InitializeComponent();
            minhaConta = umaConta;
        }

        private void FormExtrato_Load(object sender, EventArgs e)
        {
            string contaOrigem = minhaConta.id;
            ContaBancoDAL.populaExtratoDoc(contaOrigem);
        }
        private void printExtrato_PrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            Font font = new Font("Segoe UI", 12);
            Font font2 = new Font("Segoe UI", 16, FontStyle.Bold);
            Font font3 = new Font("Segoe UI", 14, FontStyle.Bold);
            int linha = 110;
            e.Graphics.DrawString("Banco Creditech", font2, mCaneta, 300, 10);
            e.Graphics.DrawString("Extrato", font2, mCaneta, 350, 40);

            e.Graphics.DrawString("   TRANSAÇÃO     |"
                                + "  C. Origem   |"
                                + "   C. Destino  |"
                                + "   Valor    |"
                                + "             Data            |", font3, mCaneta, 70, 100);

            ContaBancoDAL.getProximo();
            while (!Erro.getErro())
            {
                linha += 30;
                ++i;
                string tipo = (Registro.getTipo() == "SAQUE") ? String.Format("{0,24}", Registro.getTipo()) 
                            : (Registro.getTipo() == "DEPOSITO") ? String.Format("{0,22}", Registro.getTipo()) 
                            : String.Format("{0,16}", Registro.getTipo());

                string contaDestinoStr = (Registro.getContaDestino() == "NONE") ? " -----  " : Registro.getContaDestino()+" ";


                e.Graphics.DrawString("| " + i + " |  >\t"
                                       + tipo + "   |\t "
                                       + Registro.getContaOrigem() + "      |        "
                                       + contaDestinoStr + "      |  "
                                       + "R$  " + float.Parse(Registro.getValor()).ToString("F2") + "  |    "
                                       + Registro.getDataHoraReg() + "  |", font, mCaneta, 10, linha);
                if (i == 25)
                {
                    e.Graphics.DrawString("Página " + j, font, mCaneta, 700, 1100);
                    j++;
                    e.HasMorePages = true;
                    return;
                }
                ContaBancoDAL.getProximo();
            }
            e.Graphics.DrawString("Página " + j, font, mCaneta, 700, 1100);
            i = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            visualizador.ShowDialog();
        }

        private void visualizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormExtrato_Load(null, EventArgs.Empty);
        }
    }
}
