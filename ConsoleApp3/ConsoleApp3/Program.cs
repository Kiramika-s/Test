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
            Console.WriteLine("Введите расширение файла, который вы хотите загрузить: ");
            string inputFormat = Console.ReadLine();
            while (true)
            {
                if (inputFormat == "txt" || inputFormat == "xlsx" || inputFormat == "png")
                {
                    switch (inputFormat)
                    {
                        case "txt":
                            Console.WriteLine("Ожидание загрузки...");                            
                            ClassTXT example = new ClassTXT();
                            example.CreateFile();
                            break;
                        case "xlsx":
                            Console.WriteLine("Ожидание загрузки...");                            
                            ClassXLSX example2 = new ClassXLSX();
                            example2.CreateFile();
                            break;
                        case "png":
                            Console.WriteLine("Ожидание загрузки...");                            
                            ClassPNG example3 = new ClassPNG();
                            example3.CreateFile();
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Вы ввели некорректное расширение, повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                }


            }

            
            Console.WriteLine("Введите имя файла: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Введите путь к файлу: ");
            string inputWay = Console.ReadLine();            
            Console.Clear();

            /*if (inputFormat=="exit")
                Console.WriteLine("Выход из консоли");*/
            
            Console.WriteLine("\nВаш файл "+ inputName+"."+inputFormat+" сохранён по адресу "+ inputWay);
            string final = Console.ReadLine();
            Console.ReadKey();

            
        }
    }
}
