using System;
/*В классе Program метода Main необходимо создать два экземпляра данных классов
И связать события (подписаться) Publisher'а с подходящими методами Subscriber'a

При старте пользователю выводится на консоль сообщение: "Введите Вашу фамилию :"
Зафиксировать в переменную inputText то что ввёл пользователь
У экземпляра класса Publisher вызвать метод Start и передать туда эту текстовую переменную

Если в переменной inputText пусто - тогда в методе Start вызвать первое событие
Если в переменной inputText "Палпатин" - тогда в методе Start вызвать второе событие
Если в переменной inputText какой-то другой текст - тогда Start вызвать третье событие*/
namespace ExerciseOnDelegates
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Subscriber EventTakoeto = new Subscriber();
            Publisher EventTakoeto2 = new Publisher();
            EventTakoeto2.EventAction += EventTakoeto.WithoutParametrs;
            EventTakoeto2.EventFunc += EventTakoeto.LastName;
            EventTakoeto2.EventOneParametr += EventTakoeto.ReturnsString;

            Console.WriteLine("Введите вашу фамилию: ");
            string inputText = Console.ReadLine();
            EventTakoeto2.Start(inputText);
            if(inputText==null)
            {
                
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
