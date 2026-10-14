using System;
using System.Globalization;
using System.Text;

namespace LAB02_DiegoTeran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // para mostrar €, acentos, etc.

            // ===================== NIVEL 1 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 1 – Classe Bilhete");

            Bilhete_DT bilhete1_DT = new Bilhete_DT();

            Console.WriteLine("Numero de Bilhete: " + bilhete1_DT.GetNumeroDoBilhete_DT());
            Console.WriteLine("Hora de Bilhete: " + bilhete1_DT.GetDataHora_DT());
            Console.WriteLine("Nome do Cliente: " + bilhete1_DT.GetNomeDoCliente_DT());

            bilhete1_DT.SetNomeDoCliente_DT("Diego");
            Console.WriteLine("Nome do Cliente: " + bilhete1_DT.GetNomeDoCliente_DT());

            // ===================== NIVEL 2 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 2 – Construtores da classe Bilhete");

            Bilhete_DT bilhete2_DT = new Bilhete_DT("Diego Teran");

            Console.WriteLine("Numero de Bilhete: " + bilhete2_DT.GetNumeroDoBilhete_DT());
            Console.WriteLine("Hora de Bilhete: " + bilhete2_DT.GetDataHora_DT());
            Console.WriteLine("Nome do Cliente: " + bilhete2_DT.GetNomeDoCliente_DT());

            // ===================== NIVEL 3 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 3 – Método ToString da classe Bilhete_DT");

            Bilhete_DT bilhete3_DT = new Bilhete_DT("Óduacro Hérulo");

            Console.WriteLine(bilhete1_DT.ToString());
            Console.WriteLine(bilhete2_DT.ToString());
            Console.WriteLine(bilhete3_DT.ToString());

            // ===================== NIVEL 4 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 4 – Venda de Bilhetes");

            Console.WriteLine("Bem-vindo! Preço do bilhete: "
                + Bilhete_DT.PRECO_BILHETE_DT.ToString("0.00") + " €");
            Console.WriteLine("Por favor insira " + Bilhete_DT.PRECO_BILHETE_DT.ToString("0.00") + " €...");

            decimal quantiaInserida = Bilhete_DT.PRECO_BILHETE_DT; // simula a quantia certa
            Console.WriteLine("Quantia inserida: " + quantiaInserida.ToString("0.00") + " €");

            Bilhete_DT bilhete4_DT = new Bilhete_DT("Cliente Nível 4");
            Console.WriteLine("A imprimir bilhete...");
            Console.WriteLine(bilhete4_DT.ToString());
            Console.WriteLine("Obrigado e boa viagem!");

            // ===================== NIVEL 5 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 5 – ifs encadeados");

            Console.WriteLine("Preço do bilhete: " + Bilhete_DT.PRECO_BILHETE_DT.ToString("0.00") + " €");
            Console.Write("Insira a quantia: ");
            String entrada5 = Console.ReadLine();
            decimal quantia5;

            if (!decimal.TryParse(entrada5.Replace(',', '.'), NumberStyles.Number,
                                  CultureInfo.InvariantCulture, out quantia5) || quantia5 < 0)
            {
                Console.WriteLine("Valor inválido. Operação cancelada.");
            }
            else if (quantia5 == Bilhete_DT.PRECO_BILHETE_DT)
            {
                Bilhete_DT bilhete5_DT = new Bilhete_DT("Cliente Nível 5");
                Console.WriteLine("Quantia certa. A imprimir bilhete...");
                Console.WriteLine(bilhete5_DT.ToString());
            }
            else if (quantia5 > Bilhete_DT.PRECO_BILHETE_DT)
            {
                decimal troco5 = quantia5 - Bilhete_DT.PRECO_BILHETE_DT;
                Bilhete_DT bilhete5_DT = new Bilhete_DT("Cliente Nível 5");
                Console.WriteLine("A imprimir bilhete...");
                Console.WriteLine(bilhete5_DT.ToString());
                Console.WriteLine("Retire o seu troco: " + troco5.ToString("0.00") + " €");
            }
            else
            {
                decimal falta5 = Bilhete_DT.PRECO_BILHETE_DT - quantia5;
                Console.WriteLine("Quantia insuficiente. Faltam " + falta5.ToString("0.00") + " €.");
                Console.WriteLine("A devolver " + quantia5.ToString("0.00") + " €. Operação cancelada.");
            }

            // ===================== NIVEL 6 =====================
            Console.WriteLine("\nXXXXXXX NIVEL 6 – Estruturas de repetição");

            decimal totalInserido = 0;
            bool terminado = false;

            while (!terminado)
            {
                Console.WriteLine("\nPreço: " + Bilhete_DT.PRECO_BILHETE_DT.ToString("0.00")
                    + " €  |  Inserido: " + totalInserido.ToString("0.00") + " €");
                Console.Write("Insira uma moeda/nota (0 para cancelar): ");
                String entrada6 = Console.ReadLine();
                decimal valor6;

                if (!decimal.TryParse(entrada6.Replace(',', '.'), NumberStyles.Number,
                                      CultureInfo.InvariantCulture, out valor6) || valor6 < 0)
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
                else if (valor6 == 0)
                {
                    Console.WriteLine("Compra cancelada. A devolver " + totalInserido.ToString("0.00") + " €.");
                    terminado = true;
                }
                else
                {
                    totalInserido += valor6;

                    if (totalInserido >= Bilhete_DT.PRECO_BILHETE_DT)
                    {
                        Console.Write("Quantia suficiente. Confirmar compra? (S/N): ");
                        String resposta = Console.ReadLine();

                        if (resposta != null && resposta.Trim().ToUpper() == "S")
                        {
                            Bilhete_DT bilhete6_DT = new Bilhete_DT("Cliente Nível 6");
                            Console.WriteLine("A imprimir bilhete...");
                            Console.WriteLine(bilhete6_DT.ToString());

                            decimal troco6 = totalInserido - Bilhete_DT.PRECO_BILHETE_DT;
                            if (troco6 > 0)
                            {
                                Console.WriteLine("Retire o seu troco: " + troco6.ToString("0.00") + " €");
                            }
                            Console.WriteLine("Obrigado e boa viagem!");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada. A devolver " + totalInserido.ToString("0.00") + " €.");
                        }
                        terminado = true;
                    }
                }
            }

            Console.WriteLine("\nPrima qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}