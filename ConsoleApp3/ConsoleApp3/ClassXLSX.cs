using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class XLSXFileCreator : FileCreator
    {
        public XLSXFileCreator(string extention, string name, string path) : base(extention, name, path)
        {

        }
        public override void CreateFile()
        {
            string FileCreationProcess = "Логика создания файла XLSX";
            Console.WriteLine(FileCreationProcess);
            base.OutputData();
        }
    }
}
