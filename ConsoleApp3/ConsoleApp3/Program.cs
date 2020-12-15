using System;

namespace ConsoleApp3
{
    public class Program
    {
        
        public static void Main(string[] args)
        {            

            /*(inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")*/
           
           
            FileCreator fc = null;
            while (true)
            {
                Console.WriteLine("Введите расширение файла, который вы хотите загрузить: ");
                string inputFormat = Console.ReadLine();

                if (inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")
                {
                    Console.WriteLine("Введите имя файла: ");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Введите путь к файлу: ");
                    string inputPath = Console.ReadLine();
                                        
                    switch (inputFormat)
                    {
                        case "txt":
                            //Console.WriteLine("Ожидание загрузки...");
                            fc = new TXTFileCreator(inputFormat,inputName,inputPath);                            
                            break;
                        case "xlsx":                            
                            fc = new PNGFileCreator(inputFormat, inputName, inputPath);                            
                            break;
                        case "png":                            
                            fc = new XLSXFileCreator(inputFormat, inputName, inputPath);                            
                            break;
                    }

                    if (fc != null)
                        fc.CreateFile();
                }
               
                else if(inputFormat == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное расширение, повторите попытку");
                }
                
                
                
            }

            
            


            /*Console.WriteLine("Повторить? y/n");
            if (Console.ReadKey(true).Key != ConsoleKey.Y)
            {
                Console.WriteLine("Пока");
                Environment.Exit(0);
            }*/

        }
    }
}
