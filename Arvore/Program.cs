using System;

namespace Arvore
{
    class Program
    {
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("========== MENU DE OPÇÕES ==========");
            Console.WriteLine("====================================");
            Console.WriteLine("\n      01 - INSERIR ELEMENTO");
            Console.WriteLine("\n      02 - REMOVER ELEMENTO");
            Console.WriteLine("\n      03 - EXIBIR EM ORDEM");
            Console.WriteLine("\n      04 - EXIBIR EM PRÉ-ORDEM");
            Console.WriteLine("\n      05 - EXIBIR EM PÓS-ORDEM");            
            Console.WriteLine("\n      06 - CONTAGEM DE ELEMENTOS");
            Console.WriteLine("\n      07 - CONTAGEM DE NÓS FOLHA");
            Console.WriteLine("\n      08 - ALTURA DA ÁRVORE");
            Console.WriteLine("\n      09 - SOMAR ELEMENTOS");
            Console.WriteLine("\n      10 - NÍVEL DA ÁRVORE");
            Console.WriteLine("\n      11 - MAIOR ELEMENTO");
            Console.WriteLine("\n      12 - MENOR ELEMENTO");
            Console.WriteLine("\n      13 - MULTIPLICAR ELEMENTOS");
            Console.WriteLine("\n      14 - PERCURSO ANSESTRAL");
            Console.WriteLine("\n      15 - LIMPAR ÁRVORE");
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.Write("DIGITE A OPÇÃO DESEJADA: ");


            return (int.Parse(Console.ReadLine()));

        }

        //// Tratamento para erro de digitação.
        //try
        //{

        //}
        //catch (FormatException)
        //{

        //}
        static void Main(string[] args)
        {
            int x, op;

            arvore arv = new arvore();

            do
            {
                op = menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();



                        break;

                    case 2:
                        Console.Clear();

                        

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();

                        

                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();

                        

                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 14:
                        Console.Clear();



                        Console.ReadKey();
                        break;
                    case 15:
                        Console.Clear();



                        Console.ReadKey();
                        break;

                }
            } while (op != 15);
        }
    }
}
