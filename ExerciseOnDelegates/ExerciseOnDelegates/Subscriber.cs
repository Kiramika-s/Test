using System;
using System.Collections.Generic;
using System.Text;

/*
1. метод void (без параметров), который выводит на консоль: "Привет Инкогнито"
2. метод void с текстовым параметров lastName, который выводит на консоль: "Привет " + lastName
3. метод, который возвращает string "Моё Уважение!" и выводит на консоль "Здравствуйте Верховный Ситх!"*/

namespace ExerciseOnDelegates
{
    public class Subscriber
    {
        public void WithoutParametrs()
        {
            Console.WriteLine("Привет инкогнито");
        }
        public string LastName(string lastName)
        {            
            Console.WriteLine("Привет, " + lastName);
            return null;
            
        }
        public void ReturnsString(string lastName)
        {            
            Console.WriteLine("Здравствуйте, Верховный Ситх");
            Console.WriteLine("Моё уважение!");
            return;
        }
    }
}
