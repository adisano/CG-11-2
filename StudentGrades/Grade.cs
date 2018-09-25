using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentGrades
{
    class Grade
    {
        //create a list of integers where we'll store the user's grades
        //also create an integer where we'll store the user's average grade
        public List<int> Grades { get; set; }
        public int AverageGrade { get; set; }

        //create a method where we'll find the user's grades
        //we do this by using the ReadData() method from the Student class to read a line of data
        //from the .txt file
        public List<int> FindGrades(string studentdata)
        {
            //then we separate the name from the numbers by re-defining the string as
            //only whatever characters are after the first blank space
            studentdata = studentdata.Substring(studentdata.IndexOf(' ') + 1);
            //then we separate each number, separated by blank spaces, into an item on a list
            List<int> grades = new List<int>(Array.ConvertAll(studentdata.Split(' '), int.Parse));
            Grades = grades;
            //then we return the list
            return Grades;
        }

        //create a method where we find and return the user's average grade
        public int FindAverageGrade()
        {
            AverageGrade = Convert.ToInt32(Grades.Average());
            return AverageGrade;
        }
    }
}
