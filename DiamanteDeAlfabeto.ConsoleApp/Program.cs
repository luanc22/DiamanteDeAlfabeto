using System;

namespace DiamanteDeAlfabeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaracao de Variaveis. [OK]
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();
            string inputUsuario;
            string inputUsuarioMaiscula;
            char inputUsuarioMaisculaChar;
            int linhas = 0;

            bool opcaoValida = false;
            string fecharBotao;
            bool fecharApp = false;
            #endregion

            
            while (fecharApp == false)
            {
                #region Input de dados. [OK]
                Console.Write("Digite uma Letra do alfabeto: ");
                inputUsuario = Console.ReadLine();
                inputUsuarioMaiscula = inputUsuario.ToUpper();
                inputUsuarioMaisculaChar = char.Parse(inputUsuarioMaiscula);

                Console.WriteLine("");

                for (int i = 1; i < alfabetoArray.Length; i++)
                {
                    if (alfabetoArray[i] == inputUsuarioMaisculaChar)
                    {
                        linhas = i;
                    }
                }
                #endregion

                #region Output do Diamante. [OK]
                for (int i = 0; i <= linhas - 1 / 2; i++)
                {
                    for (int j = 1; j <= linhas - i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoArray[i]);

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    if (i == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(alfabetoArray[i]);
                        Console.WriteLine("");
                    }
                }
                
                for (int i = linhas - 2 / 2; i >= 0; i--)
                {
                    for (int j = 1; j <= linhas - i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(alfabetoArray[i]);

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    if (i == 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(alfabetoArray[i]);
                        Console.WriteLine("");
                    }
                }
                #endregion

                Console.WriteLine("");

                #region Menu. [OK]
                opcaoValida = false;
                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                    #endregion
                }
            }
        }
    }
}
