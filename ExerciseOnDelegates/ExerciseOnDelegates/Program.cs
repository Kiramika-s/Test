using System;
/*Создать консольное приложение
В данном приложении должно быть дополнительно создано два класса Publisher и Subscriber
У класса Publisher должно быть три события и один метод:
1.событие типа Action(без параметров)
2.событие типа Func<string, string>
3. событие типа delegate с одним текстовым параметром lastName
4. метод void (например Start(string lastName)), который принимает текстовый параметр lastName

В классе Subscriber должно быть три метода :
1.метод void(без параметров), который выводит на консоль: "Привет Инкогнито"
2.метод void с текстовым параметров lastName, который выводит на консоль: "Привет " + lastName
3.метод, который возвращает string "Моё Уважение!" и выводит на консоль "Здравствуйте Верховный Ситх!"

В классе Program метода Main необходимо создать два экземпляра данных классов
И связать события (подписаться) Publisher 'а с подходящими методами Subscriber'a

 При старте пользователю выводится на консоль сообщение: "Введите Вашу фамилию :"
Зафиксировать в переменную inputText то что ввёл пользователь
У экземпляра класса Publisher вызвать метод Start и передать туда эту текстовую переменную

Если в переменной inputText пусто - тогда в методе Start вызвать первое событие
Если в переменной inputText "Палпатин" - тогда в методе Start вызвать второе событие и зафиксировать то что вернуло событие и вывести это значение в консоль
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
          
        }
    }
}
