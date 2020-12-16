using System;
using System.Collections.Generic;
using System.Text;

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
            if (lastName == null)
            {
                EventAction.Invoke();
            }
            else if (lastName == "Палпатин")
            {
                Console.WriteLine(EventFunc.Invoke(lastName));                
            }
            else
            {
                EventOneParametr.Invoke(lastName);
            }
        }

    }
}
