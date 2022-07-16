public class CoefficientFromFileReader : ICoefficientReader
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

        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadLine();
                string[] bits = text.Split(' ');
                a = int.Parse(bits[0]);
                b = int.Parse(bits[1]);
                c = int.Parse(bits[2]);
            }
        }
        else
        {
            throw new FileNotFoundException("Этого файла не существует");
        }

        return new int[] { a, b, c };
    }
}
