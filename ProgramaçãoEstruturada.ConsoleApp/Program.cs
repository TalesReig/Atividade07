using System;
using System.Linq;

namespace ProgramaçãoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maiorValor = 0, menorValor;
            double[] valores = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o valor da posição " + i + ":");
                valores[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            EncontrarMaiorValor(ref maiorValor, ref valores);
            Console.WriteLine("O maior valor é: "+maiorValor);

            EncontrarMenorValor(out menorValor, valores);
            Console.WriteLine("O menor valor é: " + menorValor);

            Console.WriteLine("A média dos valores é de: "+CalculaMedia(valores));

            Console.Write("Os tres maiores valores são: ");
            EncontrarOsTresMaiores(valores);

            Console.WriteLine("Os valores digitados foram:");
            MostrarValores(valores);

            Console.WriteLine("Os valores Negativos são: ");
            EncontrarOsValoresNegativos(valores);

            // não funciona
            // Console.WriteLine("Digite o indice do valores que deseja remover:");
            // int indice = Convert.ToInt32(Console.ReadLine());
            // MostrarValores(valores);



            static void EncontrarMaiorValor(ref double maiorValor,ref double[] vetores)
            {
                maiorValor =  -99999;
                for (int i = 0; i < 10; i++)
                {
                    if(vetores[i] > maiorValor)
                    {
                        maiorValor = vetores[i];
                    }
                }
            }

            static void EncontrarMenorValor( out double menorValor, double[] valor)
            {
                menorValor = 99999;
                for (int i = 0; i < 10; i++)
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
                for (int i = 0; i < 10; i++)
                {
                    if (valor[i] < 0)
                    {
                        negativos = negativos + valor[i];
                    }
                }                                                               
                char[] vetrespostas = negativos.ToCharArray();                   
                for(int i = 0; i < vetrespostas.Length; i++)
                {   
                    if(i%2 == 0)
                    {
                        Console.Write(vetrespostas[i]);
                    }else if (i % 2 != 0 && i < (vetrespostas.Length-1))
                    {
                        Console.Write(vetrespostas[i]+", ");
                    }
                    else
                    {
                        Console.Write(vetrespostas[i] + ".");
                    }
                }
            }

            static double CalculaMedia(double[] valor)
            {
                double acumulador = 0,media;
                for (int i = 0; i < 10; i++)
                {
                    acumulador = acumulador + valor[i];
                }
                media = acumulador / 10;
                Math.Round(media, 2);
                return media;
            }

            static void EncontrarOsTresMaiores(double[] vetores)
            {
                double maiorValor1 = -99999;
                for (int i = 0; i < 10; i++)
                {
                    if (vetores[i] >= maiorValor1)
                    {
                        maiorValor1 = vetores[i];
                    }
                }
                Console.Write(maiorValor1);
                double maiorValor2 = -9999;
                for (int i = 0; i < 10; i++)
                {
                    if (vetores[i] > maiorValor2 && vetores[i] < maiorValor1)
                    {
                        maiorValor2 = vetores[i];
                    }
                }
                Console.Write(maiorValor2);
                double maiorValor3 = -9999;
                for (int i = 0; i < 10; i++)
                {
                    if (vetores[i] < maiorValor2 && maiorValor3 < vetores[i])
                    {
                        maiorValor3 = vetores[i];
                    }
                }
                Console.WriteLine(maiorValor3);
            }

            static void MostrarValores(double[] valor)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i < 9) {
                    Console.Write(valor[i] + ",");
                    } else{
                        Console.WriteLine(valor[i] + ".");
                    }
                }
            }
            
            static void RemoverValor(int indice, double[] valor)
            {
                valor = valor.Where((source, index) => index != indice).ToArray();
            }
            
        }
    }
}
