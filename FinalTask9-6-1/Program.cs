namespace FinalTask9_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyException ex1 = new MyException("Исключение 1");
            ex1.HelpLink = "http://www.google.com";
            ex1.Data.Add("Время: ", DateTime.Now);

            Exception[] exceptions = new Exception[]
            {
                ex1,
                new FileNotFoundException("Исключение 2"),
                new ArgumentNullException("Исключение 3"),
                new ArgumentOutOfRangeException("Исключение 4"),
                new ArgumentException("Исключение 5")
            };

            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}