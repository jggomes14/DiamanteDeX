using System.Security.Authentication;
using System.Text;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int numeroImparDeLados;
            while (count < 4)
            {
                Console.WriteLine("Insira o número para fazer o diamante");
                numeroImparDeLados = Convert.ToInt32(Console.ReadLine());

                if (numeroImparDeLados % 2 != 0)
                {
                    count = 3;
                    int meio = numeroImparDeLados / 2;
                    for (int i = 0; i < numeroImparDeLados; i++)
                    {
                        int distanciaDaBorda = meio - i;
                        if (distanciaDaBorda < 0)
                        {
                            distanciaDaBorda = -distanciaDaBorda;
                        }
                        for (int j = 0; j < distanciaDaBorda; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < numeroImparDeLados - 2 * distanciaDaBorda; j++)
                        {
                            Console.Write("x");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else if (numeroImparDeLados % 2 == 0 && count < 3)
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
