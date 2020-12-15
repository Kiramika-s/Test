using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class PNGFileCreator : FileCreator
    {
        public override void CreateFile()
        {
            string FileCreationProcess = "Логика создания файла PNG";
            Console.WriteLine(FileCreationProcess);
        }
    }
}
