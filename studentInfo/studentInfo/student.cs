using System;
using System.Collections.Generic;
using System.Text;

namespace studentInfo
{
    class student
    {
        public string Name;
        public int Course;
            public int PhoneNumber;
        public string Email;
        public string University;
        public string Subject;

        public student(string name,int course,string university)
        {
            Name = name;
            Course = course;
            University = university;
        }

      
       


        public void Identify(string name,int course,string university )
        {
            Console.WriteLine($"{name},{course},{university}");
        }
    }
}
