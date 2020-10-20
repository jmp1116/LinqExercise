﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var numbersSum = numbers.Sum();
            Console.WriteLine(numbersSum);
            Console.WriteLine();
            
            var numbersAverage = numbers.Average();
            Console.WriteLine(numbersAverage);
            Console.WriteLine();

            //Order numbers in ascending order and decsending order. Print each to console.
            var numbersSorted = numbers.OrderBy(x => x);
            foreach (var i in numbersSorted)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            var numberSortedDescending = numbers.OrderByDescending(x => x);
            foreach (var i in numberSortedDescending)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Print to the console only the numbers greater than 6
            var numbersGreaterSix = numbers.Where(x => x > 6);
            foreach (var num in numbersGreaterSix) { Console.WriteLine(num); }
            Console.WriteLine();

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var numbersLessThanFive = numbers.Where(x => x < 4);
            foreach (var i in numbersLessThanFive)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Change the value at index 4 to your age, then print the numbers in decsending order
            var newNumberSortedDescending = numbers.OrderByDescending(x => x).ToArray();
            newNumberSortedDescending.SetValue(28, 3);
            foreach (var i in newNumberSortedDescending) { Console.WriteLine(i); }
            Console.WriteLine();

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var startWithCorS = employees.Where(x => x.FirstName[0] == 's' || x.FirstName[0] == 'c').OrderBy(x => x.FirstName);
            foreach (var i in startWithCorS) { Console.WriteLine(i); }
            Console.WriteLine();

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            var employeesOverTwentySix = employees.Where(x => x.Age > 26);
            foreach (var i in employeesOverTwentySix) { Console.WriteLine(i.FullName); }
            Console.WriteLine();

            //Order this by Age first and then by FirstName in the same result.
            var ageName = employees.OrderBy(x => x.Age).OrderBy(x => x.FirstName);
            foreach (var i in ageName) { Console.WriteLine($"Name: {i.FullName} Age: {i.Age}"); 
            Console.WriteLine();

            //Print the Sum and then the Average of the employees' YearsOfExperience
            
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var greaterThanTenAndThirtyFive = employees.Where(x => x.YearsOfExperience > 10 && x.Age > 35);
            foreach (var x in greaterThanTenAndThirtyFive) { Console.WriteLine(x.FullName); }
            Console.WriteLine();

                //Add an employee to the end of the list without using employees.Add()
               employees = employees.Append(new Employee("New", "Employee", 29, 8)).ToList();
                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.Age}");
                }

            Console.WriteLine();

            Console.ReadLine();
        }

            #region CreateEmployeesMethod
            private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
