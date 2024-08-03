using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraP2
{
    class Registro
    {
        private static String id;
        private static String tipo;
        private static String contaOrigem;
        private static String contaDestino;
        private static String valor;
        private static DateTime dataHoraReg;

        public static void setId(String _id) { id = _id; }
        public static void setTipo(String _tipo) { tipo = _tipo; }
        public static void setContaOrigem(String _contaOrigem) { contaOrigem = _contaOrigem; }
        public static void setContaDestino(String _contaDestino) { contaDestino = _contaDestino; }
        public static void setValor(String _valor) { valor = _valor; }
        public static void setDataHoraReg(DateTime _dataHoraReg) { dataHoraReg = _dataHoraReg; }

        public static String getId() { return id; }
        public static String getTipo() { return tipo; }
        public static String getContaOrigem() { return contaOrigem; }
        public static String getContaDestino() { return contaDestino; }
        public static String getValor() { return valor; }
        public static DateTime getDataHoraReg() { return dataHoraReg; }
    }
}
