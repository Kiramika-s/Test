using System;
using System.Collections.Generic;
using System.Text;

/*1. событие типа Action (без параметров)
  2. событие типа Func<string, string>
  3. событие типа delegate с одним текстовым параметром lastName
  4. метод void (например Start(string lastName)), который принимает текстовый параметр lastName*/

namespace ExerciseOnDelegates
{
    public class Publisher
    {        
        public event Action EventAction;
        public event Func <string,string> EventFunc;
        public delegate void OneParametr(string lastName);
        public event OneParametr EventOneParametr;
        
        public void Start(string lastName)
        {
            
        }
    }
}
