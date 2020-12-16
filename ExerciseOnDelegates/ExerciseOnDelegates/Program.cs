using System;

/*Если в переменной inputText пусто - тогда в методе Start вызвать первое событие
Если в переменной inputText "Палпатин" - тогда в методе Start вызвать второе событие
Если в переменной inputText какой-то другой текст - тогда Start вызвать третье событие*/

namespace ExerciseOnDelegates
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Subscriber InstanceSubscriber = new Subscriber();
            Publisher InstancePublisher = new Publisher();
            InstancePublisher.EventAction += InstanceSubscriber.WithoutParametrs;
            InstancePublisher.EventFunc += InstanceSubscriber.LastName;
            InstancePublisher.EventOneParametr += InstanceSubscriber.ReturnsString;

            Console.WriteLine("Введите вашу фамилию: ");
            string inputText = Console.ReadLine();
            InstancePublisher.Start(inputText);
            if(inputText==null)
            {
                EventAction.Invoke();
            }
            else if(inputText=="Палпатин")
            {
                

            //зафиксировать то что вернуло событие и вывести это значение в консоль

            }
            else
            {
                
            }
        }
    }
}
