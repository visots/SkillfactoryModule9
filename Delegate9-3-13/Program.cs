namespace Delegate9_3_13
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = RandomNumber;
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);

            RandomNumberDelegate randomNumberDelegate1 = () => { return new Random().Next(0, 100); };
            Console.WriteLine( randomNumberDelegate1.Invoke());

        }

        static int RandomNumber()
        {
            return new Random().Next(0, 100);
        }
    }
}