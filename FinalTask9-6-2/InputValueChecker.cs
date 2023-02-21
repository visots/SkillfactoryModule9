using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask9_6_2
{
    internal class InputValueChecker
    {
        public delegate void CheckInputValueDelegate(int value);
        public event CheckInputValueDelegate CheckInputValueEvent;

        public void CheckInputValue()
        {
            Console.WriteLine("\n Введите значение 1 или 2");

            string val = Console.ReadLine();

            if (val != "1" && val != "2")
                throw new InputDataException("Введено некорректное значение");

            CheckInputValue(Convert.ToInt32(val));
        }

        protected virtual void CheckInputValue(int value)
        {
            CheckInputValueEvent?.Invoke(value);
        }
    }
}
