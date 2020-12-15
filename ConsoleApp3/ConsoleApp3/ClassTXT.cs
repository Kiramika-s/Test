using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class TXTFileCreator : FileCreator
    {

        public void CreateFile(string fileCreationProcess)
        {
            Console.ReadLine();
            string FileCreationProcess = "Логика создания файла TXT";
            Console.WriteLine(FileCreationProcess);
            Console.WriteLine("\nВаш файл " + Name + "." + inputFormat + " сохранён по адресу " + inputPass);
        }

    
    }
}
