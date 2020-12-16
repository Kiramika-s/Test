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
