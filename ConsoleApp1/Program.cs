

using MyProject;
using System.Text.Json;

namespace MyProject
{
    public interface MyFirstInterFace
    {
        List<string> Names { set; get; }
        void AddName(string name);
        
    }
    public class MyClass : MyFirstInterFace
    {
        public List<string> Names { set; get; } = new List<string> {"Misha"};
        void MyFirstInterFace.AddName(string name)
        {
            Names.Add(name);
        }
        
        }

    }
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            MyFirstInterFace MyClass = new MyClass();
            MyClass.AddName("Masha");
        foreach (string name in MyClass.Names)
        {
            Console.WriteLine(name);
        }
    }       
}

