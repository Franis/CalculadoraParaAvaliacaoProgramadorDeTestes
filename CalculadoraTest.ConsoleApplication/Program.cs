using CalculadoraTest.Regras;
using System;

namespace CalculadoraTest.ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string key;

            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo à aplicação de calculadora para avaliação do cargo de Programador de Testes.");
                ExecutarCalculadora();
                Console.WriteLine("Deseja executar novamente a calculadora? Digite S para SIM ou qualquer outro caractere para NÃO.");
                key = Console.ReadLine();
            } while (key.ToUpper() == "S");
        }

        private static void ExecutarCalculadora()
        {
            double num1, num2;
            double result;
            var choice = 0;
            var operation = string.Empty;
            var resultSentence = "O resultado da {0} do número {1} com o número {2} é igual a {3}.";
            var output = string.Empty;

            Console.WriteLine(">> Digite o primeiro número:");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine(">> Digite o segundo número:");

            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Números informados: {num1} e {num2}");

            Console.WriteLine(">> Para somar, digite 1.");

            Console.WriteLine(">> Para subtrair, digite 2.");

            Console.WriteLine(">> Para dividir, digite 3.");

            Console.WriteLine(">> Para multiplicar, digite 4.");

            Console.WriteLine(">> Para cancelar, digite 0.");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = CalculadoraRegras.Somar(num1, num2);
                    operation = "SOMA";
                    output = string.Format(resultSentence, operation, num1, num2, result);
                    break;

                case 2:
                    result = CalculadoraRegras.Subtrair(num1, num2);
                    operation = "SUBTRAÇÃO";
                    output = string.Format(resultSentence, operation, num1, num2, result);
                    break;

                case 3:
                    result = CalculadoraRegras.Dividir(num1, num2);
                    operation = "DIVISÃO";
                    output = string.Format(resultSentence, operation, num1, num2, result);
                    break;

                case 4:
                    result = CalculadoraRegras.Multiplicar(num1, num2);
                    operation = "MULTIPLICAÇÃO";
                    output = string.Format(resultSentence, operation, num1, num2, result);
                    break;

                case 0:
                    output = "Operação cancelada.";
                    break;

                default:
                    output = "Opção digitada não é válida! A operação será cancelada.";
                    break;
            }

            Console.WriteLine(output);

            Console.WriteLine("Pressione qualquer tecla para continuar.");

            Console.ReadKey();

            Console.Clear();
        }
    }
}