using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class FileCreator
    {
        public FileCreator(string extention, string name, string path)
        {
            Extention = extention;
            Name = name;
            Path = path;
        }

        public string Extention { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public abstract void CreateFile();


        public void OutputData()
        {
            Console.WriteLine("\nВаш файл " + Name + "." + Extention + " сохранён по адресу " + Path);
        }
        
    }
}

/*Сделать консольное приложение, которое будет создавать пустой файл одного из трёх расширений: .txt, .xlsx, .png
Необходимо реализовать один базовый класс (абстрактную фабрику) и три производных класса по работе с файлами
Каждый производный класс должен содержать свою собственную логику создания файла

Пользователь по порядку вводит три параметра:
- расширение файла
- имя файла
- путь где должен создаться файл

Если пользователь ввёл некорректное расширение - необходимо выдать пользователю ошибку и дать возможность повторить попытку
Если пользователь ввёл слово Exit - необходимо закрыть приложение*/