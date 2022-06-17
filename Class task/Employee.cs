using System;
using System.Collections.Generic;
using System.Text;

namespace Class_task
{
    class Employee : Human
    {
        public string Position;
        public Employee(string name, string surname) : base(name, surname)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Position: {Position} ");
        }
    }
}
