using System;


/*один уведомляет другого, о том, что "произошёл пинг", другой - о том, что "произошёл понг",*/


namespace ConsoleApp5
{
    public delegate void SimpleDelegate();
    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Ара");
        }
        static void Main(string[] args)
        {
            SimpleDelegate d1 = new SimpleDelegate(Method1);
        //Вызвать делегат, о соответственно метод
            d1.Invoke();
            //Сигнатура метода и делегата должны быть одинаковы
            Action action = Method1;
            action.Invoke();
        }
    }
}
