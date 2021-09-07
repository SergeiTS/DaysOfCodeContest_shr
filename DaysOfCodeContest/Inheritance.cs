using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class Inheritance
    {
    }

    class Person2
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person2() { }
        public Person2(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person2
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores) : base (firstName, lastName, id) 
        {
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public string Calculate()
        {
            int sum = 0;
            int a;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            a = sum / testScores.Length;
            if (a <= 100 && a >= 90)
                return "O";
            else if (a < 90 && a >= 80)
                return "E";
            else if (a < 80 && a >= 70)
                return "A";
            else if (a < 70 && a >= 55)
                return "P";
            else if (a < 55 && a >= 40)
                return "D";
            else if (a < 40)
                return "T";
            return "";
        }
    }
}
