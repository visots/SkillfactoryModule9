namespace FinalTask9_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputValueChecker inputValueChecker = new InputValueChecker();
            inputValueChecker.CheckInputValueEvent += OrderData;

            while (true)
            {
                try
                {
                    inputValueChecker.CheckInputValue();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static List<string> OrderDesc(List<string> list) => list.OrderByDescending(x => x).ToList();

        static List<string> OrderAsc(List<string> list) => list.OrderBy(x => x).ToList();

        static void OrderData(int inputValue)
        {
            List<string> persons = new List<string>()
            { "Петров", "Иванов", "Сидоров", "Зайцев", "Волков"};

            switch (inputValue)
            {
                case 1:
                    Console.WriteLine("\nOrdered Asc");
                    persons = OrderAsc(persons);
                    break;
                case 2:
                    Console.WriteLine("Ordered Desc");
                    persons = OrderDesc(persons);
                    break;
            }

            ShowList(persons);
        }

        static void ShowList(List<string> list)
        {
            foreach (string s in list)
                Console.WriteLine(s);
        }
    }
}