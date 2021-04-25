using System;

namespace Exercicio_AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
              decimal emprestimo, renda, parcelas , calcporcentagem, calcparcela;


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Quantia do Empréstimo...: ");
            emprestimo = decimal.Parse(Console.ReadLine());

            Console.Write("Parcelas...: ");
            parcelas = decimal.Parse(Console.ReadLine());

            Console.Write("Sua Renda Mensal...: ");
            renda = decimal.Parse(Console.ReadLine());
            Console.ResetColor();


                    calcparcela = parcelas / emprestimo;
                    calcporcentagem = (30 * renda) / 100;



                
                 if (calcporcentagem < calcparcela) 
                {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Não foi possivel o seu emprestimo.");
                     Console.ResetColor();
                } 
                 
            

                
                 else 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Emprestimo bem sucedido!!!");
                    Console.ResetColor();
                }
            
        }
    }
}
