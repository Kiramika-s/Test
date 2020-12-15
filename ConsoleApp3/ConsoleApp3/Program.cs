using System;

namespace ConsoleApp3
{
    public class Program
    {
        
        public static void Main(string[] args)
        {            

            /*(inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")*/
           
           
            FileCreator fc;
            while (true)
            {
                Console.WriteLine("Введите расширение файла, который вы хотите загрузить: ");
                string inputFormat = Console.ReadLine();

                if (inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")
                {
                    Console.WriteLine("Введите имя файла: ");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Введите путь к файлу: ");
                    string inputPass = Console.ReadLine();
                    Console.WriteLine("\nВаш файл " + inputName + "." + inputFormat + " сохранён по адресу " + inputPass);
                    Console.ReadKey();
                    switch (inputFormat)
                    {
                        case "txt":
                            //Console.WriteLine("Ожидание загрузки...");
                            fc = new TXTFileCreator();                            
                            break;
                        case "xlsx":                            
                            fc = new PNGFileCreator();                            
                            break;
                        case "png":                            
                            fc = new XLSXFileCreator();                            
                            break;
                    }
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
