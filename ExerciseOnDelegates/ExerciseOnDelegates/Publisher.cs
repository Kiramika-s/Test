using System;
using System.Collections.Generic;
using System.Text;

/*1. событие типа Action (без параметров)
  2. событие типа Func<string, string>
  3. событие типа delegate с одним текстовым параметром lastName
  4. метод void (например Start(string lastName)), который принимает текстовый параметр lastName*/

namespace ExerciseOnDelegates
{
    public event Action action = null;
    public event Func <string,string> fg;
    public delegate void bvz (string lastName);
    public event bvz NameEvent = lastName;
    class Publisher
    {
        public void WithoutParametrs()
        {

        }
        public void EventFunc()
        {

        }
        public void Start(string lastName)
        {
            lastName = Console.ReadLine();
        }
    }
}
