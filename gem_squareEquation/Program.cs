class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting...");

        string choice;
        Console.WriteLine("Выберите тип ввода коэффициентов квадратного уравнения. " +
            "Введите \"1\" или \"2\"(без кавычек), где единица значит консольный ввод, а двойка - ввод из файла.");
        choice = Console.ReadLine();

        ICoefficientReader reader;

        if (choice == "1")
        {
            reader = new CoefficientFromConsoleReader();
        }
        else 
        {
            reader = new CoefficientFromFileReader();
        }

        SquareEquationSolver solver = new SquareEquationSolver(reader.ReadCoefficients());

        var str = string.Join(" ", solver.roots);
        Console.WriteLine("\n" + str);
    }
}