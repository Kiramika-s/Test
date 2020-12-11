using System;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Пользователь по порядку вводит три параметра:
            - расширение файла
            - имя файла
            - путь где должен создаться файл*/

            /*(inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")*/
           
           
            FileCreator fc;
            while (true)
            {
                Console.WriteLine("Введите расширение файла, который вы хотите загрузить: ");
                string inputFormat = Console.ReadLine();

                if (inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")
                {
                    switch (inputFormat)
                    {
                        case "txt":
                            Console.WriteLine("Ожидание загрузки...");                            
                            fc = new ClassTXT();
                            
                            break;
                        case "xlsx":
                            Console.WriteLine("Ожидание загрузки...");                            
                            fc = new ClassXLSX();                            
                            break;
                        case "png":
                            Console.WriteLine("Ожидание загрузки...");                            
                            fc = new ClassPNG();                            
                            break;
                    }
                }
                else 
                    Console.WriteLine("Вы ввели некорректное расширение, повторите попытку");
                /*else 
                {
                    
                    Console.ReadKey();
                    Console.Clear();
                }*/
                Console.WriteLine("Введите имя файла: ");
                string inputName = Console.ReadLine();
                Console.WriteLine("Введите путь к файлу: ");
                string inputWay = Console.ReadLine();
                Console.WriteLine("\nВаш файл " + inputName + "." + inputFormat + " сохранён по адресу " + inputWay);
                Console.ReadKey();

                if (inputFormat == "exit")
                    Environment.Exit(0);
                
            }

                   

            /*if (inputFormat=="exit")
                Console.WriteLine("Выход из консоли");*/
            
            


            Console.WriteLine("Повторить? y/n");
            if (Console.ReadKey(true).Key != ConsoleKey.Y)
            {
                Console.WriteLine("Пока");
                Environment.Exit(0);
            }

        }
    }
}
