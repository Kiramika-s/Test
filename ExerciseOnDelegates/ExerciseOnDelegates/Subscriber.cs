using System;
using System.Collections.Generic;
using System.Text;

/*В классе Subscriber должно быть три метода :
1. метод void (без параметров), который выводит на консоль: "Привет Инкогнито"
2. метод void с текстовым параметров lastName, который выводит на консоль: "Привет " + lastName
3. метод, который возвращает string "Моё Уважение!" и выводит на консоль "Здравствуйте Верховный Ситх!"*/

namespace ExerciseOnDelegates
{
    class Subscriber
    {
        public void dfg()
        {
            Console.WriteLine("Привет инкогнито");
        }
        public void sdf(string lastName)
        {
            Console.WriteLine("Привет, " + lastName);
        }
        public string djphf ()
    }
}
