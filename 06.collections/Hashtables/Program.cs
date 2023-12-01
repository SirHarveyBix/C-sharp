﻿using System;
using System.Collections;

namespace Hashtables;
class Program
{
    static void Main(string[] args)
    {
        //Declare a Hashtable
        Hashtable studentsTable = new Hashtable();

        // Create values
        Student student1 = new Student(1, "Maria", 98);
        Student student2 = new Student(2, "Kevain", 76);
        Student student3 = new Student(3, "Clara", 45);
        Student student4 = new Student(4, "Montgomery", 55);

        // Fill hashtables
        studentsTable.Add(student1.Id, student1);
        studentsTable.Add(student2.Id, student2);
        studentsTable.Add(student3.Id, student3);
        studentsTable.Add(student4.Id, student4);

        // retrive individual item from Hashtable
        Student storedStudent = (Student)studentsTable[student1.Id];
        Console.WriteLine("Student ID: '{0}', Name: '{1}', GPA: '{2}'\n", storedStudent.Id, storedStudent.Name, storedStudent.GPA);

        // retrive all values from hashtable
        foreach (DictionaryEntry entry in studentsTable)
        {
            Student temporaryStudent = (Student)entry.Value;

            Console.WriteLine("temporaryStudent ID: '{0}'", temporaryStudent!.Id);
            Console.WriteLine("temporaryStudent Name: '{0}'", temporaryStudent.Name);
            Console.WriteLine("temporaryStudent GPA: '{0}'\n", temporaryStudent.GPA);
        }

        // retrive all values from hashtable - KISS:
        foreach (Student student in studentsTable.Values)
        {
            Console.WriteLine("Student ID: '{0}'", student.Id);
            Console.WriteLine("Student Name: '{0}'", student.Name);
            Console.WriteLine("Student GPA: '{0}'\n", student.GPA);
        }
    }
}
