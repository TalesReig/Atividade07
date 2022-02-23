using System;

namespace ProgramaçãoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maiorValor = 0, menorValor;
            double[] valores = new double[]
            {
                -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
            };

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write("Digite o valor da posição " + i + ":");
            //     valores[i] = Convert.ToDouble(Console.ReadLine());
            // }
            // Console.Clear();

            Console.Write("A sequência é:");
            MostrarValores(valores);

            Console.WriteLine();

            EncontrarMaiorValor(ref maiorValor, ref valores);
            Console.WriteLine("O maior valor é: "+maiorValor);

            EncontrarMenorValor(out menorValor, valores);
            Console.WriteLine("O menor valor é: " + menorValor);

            Console.WriteLine("A média dos valores é de: "+CalculaMedia(valores));

            Console.Write("Os tres maiores valores são: ");
            EncontrarOsTresMaiores(valores);

            Console.Write("Os valores Negativos são: ");
            EncontrarOsValoresNegativos(valores);


            Console.Write("Digite um valor para ser removido: ");
            double remover = Convert.ToDouble(Console.ReadLine());
            removerItem(ref valores, ref remover);
            Console.Write("Valor com o número removido: ");
            MostrarVetorAtualizado(valores);

        }

        static void EncontrarMaiorValor(ref double maiorValor, ref double[] vetores)
        {
            maiorValor = -99999;
            for (int i = 0; i < vetores.Length; i++)
            {
                if (vetores[i] > maiorValor)
                {
                    maiorValor = vetores[i];
                }
            }
        }

        static void EncontrarMenorValor(out double menorValor, double[] valor)
        {
            menorValor = 99999;
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] < menorValor)
                {
                    menorValor = valor[i];
                }
            }
        }

        static void EncontrarOsValoresNegativos(double[] valor)
        {
            string negativos = "";
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] < 0)
                {
                    negativos = negativos + valor[i];
                }
            }
            char[] vetrespostas = negativos.ToCharArray();
            for (int i = 0; i < vetrespostas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(vetrespostas[i]);
                }
                else if (i % 2 != 0 && i < (vetrespostas.Length - 1))
                {
                    Console.Write(vetrespostas[i] + ", ");
                }
                else
                {
                    Console.WriteLine(vetrespostas[i] + ".");
                }
            }
        }

        static double CalculaMedia(double[] valor)
        {
            double acumulador = 0, media;
            for (int i = 0; i < valor.Length; i++)
            {
                acumulador = acumulador + valor[i];
            }
            media = acumulador / (valor.Length);
            Math.Round(media, 2);
            return media;
        }

        static void EncontrarOsTresMaiores(double[] vetores)
        {
            double maiorValor1 = -99999;
            for (int i = 0; i < vetores.Length; i++)
            {
                if (vetores[i] >= maiorValor1)
                {
                    maiorValor1 = vetores[i];
                }
            }
            Console.Write(maiorValor1+", ");
            double maiorValor2 = -9999;
            for (int i = 0; i < vetores.Length; i++)
            {
                if (vetores[i] > maiorValor2 && vetores[i] < maiorValor1)
                {
                    maiorValor2 = vetores[i];
                }
            }
            Console.Write(maiorValor2+", ");
            double maiorValor3 = -9999;
            for (int i = 0; i < vetores.Length; i++)
            {
                if (vetores[i] < maiorValor2 && maiorValor3 < vetores[i])
                {
                    maiorValor3 = vetores[i];
                }
            }
            Console.WriteLine(maiorValor3+".");
        }

        static void MostrarValores(double[] valor)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    Console.Write(valor[i] + ",");
                }
                else
                {
                    Console.WriteLine(valor[i] + ".");
                }
            }
        }

        static void removerItem(ref double[] numeros, ref double excluir)
        {
            int numeroParaRemover = 0, j = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == excluir)
                {
                    numeroParaRemover = numeroParaRemover + 1;
                }
            }

            double[] listaComORemovido = new double[numeros.Length - numeroParaRemover];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] != excluir)
                {
                    listaComORemovido[j] = numeros[i];
                    j = j + 1;
                }
            }
            numeros = listaComORemovido;
        }
        static void MostrarVetorAtualizado(double[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i < numeros.Length - 1)
                {
                    Console.Write(numeros[i] + ", ");
                }
                else
                {
                    Console.Write(numeros[i]);
                }
            }
        }


    }
}
