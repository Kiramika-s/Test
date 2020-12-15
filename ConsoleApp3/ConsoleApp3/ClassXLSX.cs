using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class XLSXFileCreator : FileCreator
    {
        public override void CreateFile()
        {
            string FileCreationProcess = "Логика создания файла XLSX";
            Console.WriteLine(FileCreationProcess);
        }
    }
}
