using System.Data;
namespace Triangulator.ConsoleApp
{
    internal class TriangulatorApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Triangulo triangulo = new Triangulo();

                triangulo.X = RecebeLado("Digite o Lado X: ");
                triangulo.Y = RecebeLado("Digite o Lado Y: ");
                triangulo.Z = RecebeLado("Digite o Lado Z: ");

                Console.WriteLine("Tipo do Triangulo:  " + triangulo.ObterTipo());

                if (DeveContinuar() == "N")
                    break;
            }
        }

        static string DeveContinuar()
        {
            Console.WriteLine("\nDeseja verificar outro triangulo ? [S,N]");
            return Console.ReadLine();
        }

        static int RecebeLado(string texto)
        {
            Console.Write(texto);

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
