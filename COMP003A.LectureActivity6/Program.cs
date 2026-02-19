// See https://aka.ms/new-console-template for more information
using COMP003A.LectureActivity6;
using System;


public class Program
{
    static void Main(string[] args)
    {

    Student student = new Student("Brianna", 20);
    Student  student1 = new Student("Alexa", 30);
    
    
    
    
    student.DisplayInfo();
    student1.DisplayInfo();
    
    
    student.Age = 19;
    
    student.DisplayInfo();
    
    
    }
    
    
    






}



/*
    Why does each Student object have its own data?
   
   
   
    Why does Main not need to know how DisplayInfo works?
   
   
   
    How does this activity demonstrate encapsulation conceptually?
    
    
    
*/