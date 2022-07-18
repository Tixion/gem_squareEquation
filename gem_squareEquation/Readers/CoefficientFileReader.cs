public class CoefficientFileReader : ICoefficientReader
{
    public int[] ReadCoefficients()
    {
        int a = 0;
        int b = 0;
        int c = 0;
        string path = "";

        do
        {
            Console.Write("Введите название файла (в виде \"название.txt\", без кавычек): ");
            path = Console.ReadLine();
        } while (path == null || path == "" || !path.EndsWith(".txt"));

        if (!File.Exists(path)) throw new FileNotFoundException("Этого файла не существует");
        
        using (StreamReader reader = new StreamReader(path))
        {
            string text = reader.ReadLine();
            string[] bits = text.Split(' ');
            a = int.Parse(bits[0]);
            b = int.Parse(bits[1]);
            c = int.Parse(bits[2]);
        }
        
        return new int[] { a, b, c };
    }
}
