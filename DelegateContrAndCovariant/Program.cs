namespace DelegateContrAndCovariant
{
    internal class Program
    {
        delegate Car CarDelegate();
        delegate void ChildDelegate(Child child);

        static void Main(string[] args)
        {
            //Ковариация
            CarDelegate carDelegate = CarHandler;
            CarDelegate carDelegate1 = LexusHandler;

            ChildDelegate childDelegate = GetParent;
            childDelegate.Invoke(new Child());

            Console.WriteLine("Hello, World!");
        }

        static Car CarHandler()
        {
            return null;
        }

        static Lexus LexusHandler()
        {
            return null;
        }

        static void GetParent(Parent parent)
        {
            Console.WriteLine(parent.GetType());
        }

    }

    class Car { }
    class Lexus : Car { }

    class Parent { }
    class Child : Parent { }
}