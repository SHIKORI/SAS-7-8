using System.Security.Cryptography;

namespace brrt_brrt_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "Angel" + "Locsin";
            person1.BirthYear = 30;
            Console.WriteLine("Hello " + person1.name);
            Console.WriteLine("You are " + person1.BirthYear + " years old.");
        }
    }
}