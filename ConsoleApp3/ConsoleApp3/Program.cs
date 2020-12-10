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
            Console.WriteLine("Введите расширение файла, который вы хотите загрузить: ");
            string inputFormat = Console.ReadLine();
                      
                switch (inputFormat)
                {
                    case "txt":
                        Console.WriteLine("Ожидание загрузки...");
                        System.Threading.Thread.Sleep(500);
                        ClassTXT example = new ClassTXT();
                        example.CreateFile("a");                        
                        break;
                    case "xlsx":
                        Console.WriteLine("Ожидание загрузки...");
                        System.Threading.Thread.Sleep(500);
                        ClassXLSX example2 = new ClassXLSX();
                        example2.CreateFile("a");                        
                        break;
                    case "png":
                        Console.WriteLine("Ожидание загрузки...");
                        System.Threading.Thread.Sleep(500);
                        ClassPNG example3 = new ClassPNG();
                        example3.CreateFile("a");                        
                        break;                    
                    default:
                        while (inputFormat != "txt" || inputFormat != "xlsx" || inputFormat != "png")
                        {
                            Console.WriteLine("Вы ввели некорректное расширение, повторите попытку");
                            
                        }
                        break;
                    
                }

            Console.Clear();
            Console.WriteLine("Введите имя файла: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Введите путь к файлу: ");
            string inputWay = Console.ReadLine();            
            Console.Clear();

            /*if (inputFormat=="exit")
                Console.WriteLine("Выход из консоли");*/
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".");
            System.Threading.Thread.Sleep(440);
            Console.Write(".\n");          

            Console.WriteLine("\nВаш файл "+ inputName+"."+inputFormat+" сохранён по адресу "+ inputWay);
            string final = Console.ReadLine();

            while (final != "exit")
            {
                Console.ReadKey();
            }
        }
    }
}
