namespace Triangulator.ConsoleApp
{
    internal partial class Program
    {
        public class Triangulator
        {
            public int X, Y, Z;

            public void ValidaTriangulo(ref string continua)
            {
                do
                {
                    continua = null;

                    Console.Clear();

                    X = RecebeLado("Lado X: ");
                    Y = RecebeLado("Lado Y: ");
                    Z = RecebeLado("Lado Z: ");

                    if (X > (Y + Z) || Y > (X + Z) || Z > (Y + X) || X == 0 || Y == 0 || X == 0)
                    {
                        Console.WriteLine("Não é um triângulo!");
                        if (DeveContinuar(ref continua)) break;
                    }
                }
                while (continua != "N" && continua != "n" && continua != null);
            }

            public void DefineTipo()
            {
                int[] lados = { X, Y, Z };
                Array.Sort(lados);

                if (X == Y && X == Z && Y == Z) Console.WriteLine("Triângulo Equilátero");
                else if (X == Z || X == Y || Y == Z) Console.WriteLine("Triângulo Isósceles");
                else if (Math.Pow(lados[2], 2) == Math.Pow(lados[0], 2) + Math.Pow(lados[1], 2)) Console.WriteLine("Triângulo Retângulo");
                else Console.WriteLine("Triângulo Escaleno");
            }
        }
    }
}
