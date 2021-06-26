using System;
using System.collections.Generic;

namespace Dio.Banco
{
    class Program
    {
        static List<Conta> listConta = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario =ObterOpcaoUsuario();

            while(opcaoUsuario =.ToUpper() ! = "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;               

                    default:
                    throw new ArgumentOutOfRangeException
                    ();
                }

                opcaoUsuario=ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por Utilizar nossos Serviços.");
            Console.ReadLine();
        }

        private static void Depositar()
        {
            Console.Write("Digite o numero da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            
            listConta[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o numero da conta: ")
            int indiceConta=int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listConta[indiceConta].Saque(valorSaque);

        }

        private static void Transferir()

    }
}