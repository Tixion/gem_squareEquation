using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SquareEquationSolver
{
    public double[] roots { get; }

    public SquareEquationSolver(int[] coeffs)
    {
        double x1;
        double x2;
        int a = coeffs[0];
        int b = coeffs[1];
        int c = coeffs[2];

        if (a + b + c == 0)
        {
            x1 = c / a;
            x2 = 1;
            roots = new double[] { x1, x2 };
        }
        if (a - b + c == 0)
        {
            x1 = -1 * c / a;
            x2 = -1;
            roots = new double[] { x1, x2 };
        }

        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Корней нет");
            roots = new double[] { 0, 0 };
        }
        if (D == 0)
        {
            x1 = -1 * b / (2 * a);
            roots = new double[] { x1 };
        }

        x1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
        x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);

        roots = new double[] { x1, x2 };
    }

    /*public static double[] solveEquation(double a, double b, double c)
    {
        double x1;
        double x2;

        if (a + b + c == 0)
        {
            x1 = c / a;
            x2 = 1;
            return new double[] { x1, x2 };
        }
        if (a - b + c == 0)
        {
            x1 = -1 * c / a;
            x2 = -1;
            return new double[] { x1, x2 };
        }

        double D = b * b - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("Корней нет");
            return new double[] { 0, 0 };
        }
        if (D == 0)
        {
            x1 = -1 * b / (2 * a);
            return new double[] { x1 };
        }

        x1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
        x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);

        return new double[] { x1, x2 };
    }*/
}
