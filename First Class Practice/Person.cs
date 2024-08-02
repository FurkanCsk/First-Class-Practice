using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class_Practice
{
    public class Person
    {
        private string name;
        private string surname;
        private string role;
        private DateTime birthday;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Role
        {
            get 
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    Console.WriteLine("Doğum tarihi şu anki tarihten ileride olamaz.");
                }
                else
                {
                    birthday = value;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Adı :{name}\nSoyadı :{surname}\nRolü : {role}\nDoğum Tarihi :{birthday.ToString("yyyy.MM.dd")}\n");
        }
    }
}
