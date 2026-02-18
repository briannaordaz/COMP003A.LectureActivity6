namespace COMP003A.LectureActivity6;
using System;
public class Student
{
   
        
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
                Name = name;
                Age = age;
        }

        public void DisplayInfo()
        {
                Console.WriteLine($"Student Name: {Name} \n Student Age: {Age}");
               
        }

}

