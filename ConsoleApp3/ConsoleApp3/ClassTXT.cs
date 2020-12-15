using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class TXTFileCreator : FileCreator
    {

        public override void CreateFile()
        {
            Extention = Console.ReadLine();
            string FileCreationProcess = "Логика создания файла TXT";
            Console.WriteLine(FileCreationProcess);
            Console.WriteLine("\nВаш файл " + Name + "." + Extention + " сохранён по адресу " + Pass);
        }

    
    }
}
