using System.Data;
namespace Triangulator.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Triangulator triangulo = new Triangulator();
                string continua = null;

                triangulo.ValidaTriangulo(ref continua);

                if (continua == "N" || continua == "n") break;

                triangulo.DefineTipo();

                if (DeveContinuar(ref continua)) break;
            }
        }

        static bool DeveContinuar(ref string continua)
        {
            Console.WriteLine("\nDeseja tentar novamente? [S,N]");
            continua = Console.ReadLine();
            return continua == "N" || continua == "n";
        }
    }
}
