﻿using Individuellt_databasprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuellt_databasprojekt
{
    internal class GetStudents
    {
        public static void Students(HighSchoolDbContext context)
        {
            Console.WriteLine("Vill du sortera efter förnamn eller efternamn (förnamn/efternamn)");
            string sortOrder = Console.ReadLine();
            var searchforLastName = sortOrder.ToLower() == "efternamn";
            IOrderedQueryable<Student>? StudentList;
            if (searchforLastName)
            {
                StudentList = context.Students.OrderBy(s => s.Lname);
            }
            else
            {
                StudentList = context.Students.OrderBy(s => s.Fname);
            }
            foreach (var student in StudentList)
            {
                Console.WriteLine($"{student.Fname} {student.Lname} - Class: {student.Class} - SSN: {student.Ssn}");
            }
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
