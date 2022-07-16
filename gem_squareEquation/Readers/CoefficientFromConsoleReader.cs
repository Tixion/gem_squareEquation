public class CoefficientFromConsoleReader : ICoefficientReader
{
    public int[] ReadCoefficients()
    {
        int a = 0;
        int b = 0;
        int c = 0;

        Console.WriteLine("Введите коэффициенты квадратного уравнения.");

        Console.Write("a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("c: ");
        c = Convert.ToInt32(Console.ReadLine());

        return new int[] { a, b, c };
    }
}
