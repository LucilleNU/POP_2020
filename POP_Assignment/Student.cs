using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace POP_Assignment
{
    class Student : Person
    {
        public string Student_number;
        public int Age;
        public string Full_name;
        public int[] Scores;
        public double average_score;



        public Student(string first_name, string last_name, string student_number, int age, int[] scores)
        {
            First_name = first_name;
            Last_name = last_name;
            Student_number = student_number;
            Age = age;
            Scores = scores;

            Full_name = first_name + " " + last_name;
            average_score = Queryable.Average(scores.AsQueryable());

        }

    }
}

