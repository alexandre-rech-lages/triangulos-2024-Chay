namespace Triangulator.ConsoleApp;

public class Triangulo
{
    public int X, Y, Z;     

    private bool AlgumLadoEstaZerado()
    {
        return X == 0 || Y == 0 || X == 0;
    }

    private bool LadoZInvalido()
    {
        return Z > (Y + X);
    }

    private bool LadoYInvalido()
    {
        return Y > (X + Z);
    }

    private bool LadoXInvalido()
    {
        return X > (Y + Z);
    }

    public string ObterTipo()
    {
        if (AlgumLadoEstaZerado() ||
            LadoXInvalido() || LadoYInvalido() || LadoZInvalido())
        {
            return "Não é um triângulo!";
        }

        int[] lados = { X, Y, Z };
        Array.Sort(lados);

        if (Math.Pow(lados[2], 2) == Math.Pow(lados[0], 2) + Math.Pow(lados[1], 2))
            return "Triângulo Retângulo";

        else if (X == Y && X == Z && Y == Z) 
            return "Triângulo Equilátero";

        else if (X == Z || X == Y || Y == Z) 
            return "Triângulo Isósceles";            

        else 
            return "Triângulo Escaleno";
    }
}   

