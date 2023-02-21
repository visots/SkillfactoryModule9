namespace SkillfactoryModule9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DeltaDelegate opDelegat = Difference;
            opDelegat += Sum;

            opDelegat(5, 10);

            opDelegat -= Sum;

            opDelegat(5, 10);

            Console.WriteLine();

            

        }

        public delegate void DeltaDelegate(int a, int b);

        static void Difference (int a, int b) =>  Console.WriteLine(b-a);

        static void Sum(int a, int b) => Console.WriteLine(a+b);
    }
}