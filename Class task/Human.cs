using System;
using System.Collections.Generic;
using System.Text;

namespace Class_task
{
    class Human
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                
                if (CheckName(value))
                {
                    _name = value;
                }

               
            }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            { 
                if (CheckSurname(value))
                {
                    _surname = value;
                }

            }
        }

        public int Age;
        public Human(string name , string surname )
        {
            Name = name;
            Surname = surname;
        } 
        public virtual void ShowInfo ()
        {
            Console.WriteLine($"Name: {Name}  Surname: {Surname}  Age {Age}") ;
        }
        public bool CheckName (string name) 

        {
            bool check = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    return false;

                } 
               
            } return true;
        } 
        public bool CheckSurname (string surname)
        {
            bool check = false;
            for (int i = 0; i < surname.Length; i++)
            {
                if (!Char.IsLetter(surname[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
