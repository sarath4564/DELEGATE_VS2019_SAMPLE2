using System;

namespace DELEGATE_VS2019_SAMPLE2
{
    public delegate void MyDelegate();
    class Program
    {
        static void Main()
        {
            Function();
            MyDelegate del = new MyDelegate(Function);
            del.Invoke();
            MyDelegate del2 = fun;
            del2();
        }
        static void Function()
        {
            Console.WriteLine("DELEGATE1");
        }
        static void fun()
        {
            Console.WriteLine("fun() method");
        }
    }
}
