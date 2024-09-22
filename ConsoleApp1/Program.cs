﻿

using MyProject;

namespace MyProject
{
    public interface MyFirstInterFace
    {
        List<string> Names { set; get; }
        void AddName(string name);
        void Delete(string name);
        
    }
    public class MyClass : MyFirstInterFace
    {
        public List<string> Names { set; get; } = new List<string> {"Misha"};
        void MyFirstInterFace.AddName(string name)
        {
            Names.Add(name);
        }
        void MyFirstInterFace.Delete(string name) { 
            if (Names.Contains(name))
            {
                Names.Remove(name);
                Console.WriteLine($"Имя {name} удалено из списка");
            }
            else {
                Console.WriteLine("Мне нечего удалять");
            }
        
        }
        
        }

    }
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            MyFirstInterFace MyClass = new MyClass();
            MyClass.AddName("Katya");
        MyClass.Delete("Sasha");
           
        foreach (string name in MyClass.Names)
        {
            Console.WriteLine(name);
        }
    }       
}

