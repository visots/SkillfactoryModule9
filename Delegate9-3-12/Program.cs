namespace Delegate9_3_12
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");

            ShowMessageDelegate showMessageDelegate1 = (_message) => Console.WriteLine(_message);
            showMessageDelegate1.Invoke("123");
            
            Console.Read();

        }
    }
}