using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class TXTFileCreator : FileCreator
    {
        //base отослал к FileCreator
        public TXTFileCreator (string extention, string name, string path):base(extention,name,path)
        {
        //на этот момент свойства уже имеют значения
        }
        public override void CreateFile()
        {
            string FileCreationProcess = "Логика создания файла TXT";
            Console.WriteLine(FileCreationProcess);
            base.OutputData();
        }

    
    }
}
