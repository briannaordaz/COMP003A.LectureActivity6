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
    
    
    student.Age = 19; //modified Age
    
    student.DisplayInfo();
    
    
    }
    
    
    






}



/*
      Why does each Student object have its own data?
        
             Each Student object has its own data because each object has its own unique values stored in the memory.
        
         Why does Main not need to know how DisplayInfo works?
        
             Main does not need to know how DisplayInfo works because the implementation details are in the DisplayInfo method already, so the Main method only needs to call the DisplayInfo() method.
        
         How does this activity demonstrate encapsulation conceptually?
         
             This acti  vity demonstrates encapsulation by showing how to hide the implementaion details and only being able access it through method invocation
    
*/