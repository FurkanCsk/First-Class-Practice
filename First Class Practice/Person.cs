using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class_Practice
{
    public class Person 
    {
        private string name;      // A field for person's information
        private string surname;
        private string role;
        private DateTime birthday;


        public string Name { get; set; } // Defining properties 
        public string Surname { get; set; }
        public string Role { get; set; }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if(value > DateTime.Now)  // An if condition that verifies the accuracy of the birth date
                {
                    Console.WriteLine("Doğum tarihi şu anki tarihten ileride olamaz.");
                }
                else
                {
                    birthday = value;
                }
            }
        }

        public void Print()   // A method that prints the person's information
        {
            Console.WriteLine($"Adı :{name}\nSoyadı :{surname}\nRolü : {role}\nDoğum Tarihi :{birthday.ToString("yyyy.MM.dd")}\n");
        }
    }
}
