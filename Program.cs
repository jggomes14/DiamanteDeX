using System.Security.Authentication;
using System.Text;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n;
            while (count < 4)
            {

                Console.WriteLine("Insira o número para fazer o diamante");
                n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 != 0)
                {
                    count = 3;
                    int meio = n / 2;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < Math.Abs(meio - i); j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < n - 2 * Math.Abs(meio - i); j++)
                        {
                            Console.Write("x");
                        }
                        Console.WriteLine();

                    }
                break;
                }
                else if (n % 2 == 0 && count < 3)
                {
                    Console.WriteLine("Número Inválido");
                    count = count + 1;
                }
                else if (count == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Máximo de Tentativas atingido, você retornará ao menu principal");
                    count = count + 1;
                }

            }
        }
    }
}
