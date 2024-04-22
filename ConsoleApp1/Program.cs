using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name  = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birth = new DateTime(year, month, day);

            Person obj = new Person(name, birth);

    

            obj.NavnCount();
            obj.GetAgeArray();
            //obj.GetAge();//


            Console.ReadLine();
        }

        
    }
}
