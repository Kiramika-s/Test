using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3
{
    class Class1
    {
        public void Test()
        {
            int[] array = new int[100] ;
            
            List<int> intList = new List<int>() {1,2,3,4};
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);
            intList.Add(5);

            int max = intList.Max();
            intList.Where(x => x > 2);

            int result = intList.First( x => x == 5);

            Dictionary<int, string> persons = new Dictionary<int, string>();
            persons.Add(123443243, "Иванов");
            persons.Add(423423423, "Петров");

            string fio = persons[123443243];
        }

        
    }
}
