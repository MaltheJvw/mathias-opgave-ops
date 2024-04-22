using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Person
    {
        public Person(string navn, DateTime birth)
        {
            _navn = navn;
            _birth = birth;

        }
        
        private string _navn;
        private DateTime _birth;


        public void NavnCount()
        {
            Console.WriteLine(_navn);
            Console.WriteLine(_navn.Length);
            
        }
        public void GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - _birth.Year;


            if (_birth.Date > today.AddYears(-age)) age--;

            for (int i = age; i >= 0; i--)
            {
                Console.WriteLine($"Year {i}: {_birth.Year + i}");
            }

            Console.WriteLine(age);
        }

        public void GetAgeArray()
        {
            var age = DateTime.Today.Year - _birth.Year;
            int[] ageCount = new int[age];            
            
            for (int i = 0; i < age; i++)
            {
                ageCount[i] = i;
                
            }
            foreach (var item in ageCount)
            {
                Console.WriteLine($"Age: {item}");
            }
            Console.ReadLine();
            
        }
    }
}
