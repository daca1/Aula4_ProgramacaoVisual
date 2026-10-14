using System;

namespace LAB02_DiegoTeran
{
    internal class Bilhete_DT
    {
        // Campos
        public const decimal PRECO_BILHETE_DT = 2.50M;

        private static int bilhetesEmitidos_DT;

        private int numeroDoBilhete_DT;
        private DateTime dataHora_DT;
        private String nomeDoCliente_DT;

        // Construtores
        public Bilhete_DT(String nomeDoCliente_DT)
        {
            this.nomeDoCliente_DT = nomeDoCliente_DT;
            dataHora_DT = DateTime.Now;
            bilhetesEmitidos_DT++;
            numeroDoBilhete_DT = bilhetesEmitidos_DT;
        }

        public Bilhete_DT() : this("Sem Nome")
        {
        }

        // Getters C, D e E
        public int GetNumeroDoBilhete_DT()
        {
            return numeroDoBilhete_DT;
        }

        public DateTime GetDataHora_DT()
        {
            return dataHora_DT;
        }

        public String GetNomeDoCliente_DT()
        {
            return nomeDoCliente_DT;
        }

        // Setter
        public void SetNomeDoCliente_DT(String nomeDoCliente_DT)
        {
            this.nomeDoCliente_DT = nomeDoCliente_DT;
        }

        // ToString
        public override String ToString()
        {
            return "********************************************\n"
                 + "** Bilhete Número: " + numeroDoBilhete_DT
                 + "  ***  " + dataHora_DT.ToString("yyyy/M/d  HH:mm:ss") + "\n"
                 + "** " + nomeDoCliente_DT + "\n"
                 + "********************************************";
        }
    }
}