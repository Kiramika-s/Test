using System;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine("Здравствуйте, Верховный Ситх");
            return "Моё уважение!";
        }
        public void ReturnsString(string lastName)
        {
            Console.WriteLine("Привет " + lastName);
            
        }
    }
}
