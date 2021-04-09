using System;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        #region Requisito 01 [OK]
        // Nossa calculadora deve ter a possibilidade de somar dois números [OK]
        #endregion

        #region Requisito 02 [OK]
        // Nossa calculadora deve ter a possibildade de fazer várias operações de soma[OK] 
        #endregion

        #region Requisito 03 [OK]
        // Nossa calculadora deve ter a possibildade de fazer várias operações de soma e de subtração[OK]
        #endregion

        #region Requisito 04 [OK]
        // Nossa calculadora deve ter a possibildade de fazer as quatro operações básicas da matemática[OK]
        #endregion

        #region Requisito 05 [OK]

        // Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]

        // Nossa calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06 [OK]

        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         */
        #endregion

        static void Main(string[] args)
{
            string opcao = "";
        
            while (true)
            {
                Console.WriteLine("Calculadora Tabajara 1.6.1");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicação");

                Console.WriteLine("Digite 4 para divisão");

                Console.WriteLine("Digite 5 para visualizar as operações realizadas");

                Console.WriteLine("Digite S para sair");

                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3"
                    && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s") //AND
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Opção Inválida! Tente novamente.");

                    Console.ResetColor();

                    Console.ReadLine();

                    Console.Clear();

                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                double primeiroNumero, segundoNumero;

                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.Write("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());

                    if (opcao == "4" && segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Segundo Número Inválido! Tente novamente");

                        Console.ResetColor();

                        Console.ReadLine();
                    }
                } while (opcao == "4" && segundoNumero == 0);

                double resultado = 0;

                string simboloOperacao = "";

                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        simboloOperacao = "+";
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "-";
                        break;

                    case "3":
                        resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "*";
                        break;

                    case "4":
                        resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "/";
                        break;

                    default:
                        break;

                }

                string operacaoRealizada =
                    primeiroNumero.ToString() + " " + simboloOperacao + " " +
                    segundoNumero.ToString() + " = " + resultado.ToString();


                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.WriteLine(operacaoRealizada);

                Console.ReadLine();
                    
            }
               
        }

    
    }
}