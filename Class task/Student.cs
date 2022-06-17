using System;
using System.Collections.Generic;
using System.Text;

namespace Class_task
{
    internal class Student : Human
    {
        public string GroupNo;
        public string Grade;

        public Student(string name, string surname) : base(name, surname)
        {

        }
        public override void ShowInfo()
        {
           
            Console.WriteLine($"Name: {Name}  Surname: {Surname}  Age: {Age}  GroupNo: {GroupNo} Grade: {Grade} ");
        } 
      
    }
}
