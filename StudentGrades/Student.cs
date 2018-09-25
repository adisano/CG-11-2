using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StudentGrades
{
    class Student
    {
        //create some strings where we'll store the data within the text file and the student's names
        public string StudentData { get; set; }
        public string StudentName { get; set; }

        //create a new streamreader
        StreamReader sr = new StreamReader("C:\\Users\\Owner\\Documents\\studentdata.txt");

        //create a method that uses the streamreader to read the data in the file
        //and store it in one of the strings we created
        public string ReadData()
        {
            StudentData = sr.ReadLine();
            return StudentData;
        }

        //create a method that returns a string containing the name on the line read by
        //the streamreader.
        //we do this by replacing all the numbers and spaces in the string with empty strings.
        public string FindStudentName()
        {

            for (int i = 0; i < StudentData.Length; i++)
            {
                if (StudentData[i] == '1')
                {
                    StudentData = StudentData.Replace("1", "");
                    i--;
                }
                else if (StudentData[i] == '2')
                {
                    StudentData = StudentData.Replace("2", "");
                    i--;
                }
                else if (StudentData[i] == '3')
                {
                    StudentData = StudentData.Replace("3", "");
                    i--;
                }
                else if (StudentData[i] == '4')
                {
                    StudentData = StudentData.Replace("4", "");
                    i--;
                }
                else if (StudentData[i] == '5')
                {
                    StudentData = StudentData.Replace("5", "");
                    i--;
                }
                else if (StudentData[i] == '6')
                {
                    StudentData = StudentData.Replace("6", "");
                    i--;
                }
                else if (StudentData[i] == '7')
                {
                    StudentData = StudentData.Replace("7", "");
                    i--;
                }
                else if (StudentData[i] == '8')
                {
                    StudentData = StudentData.Replace("8", "");
                    i--;
                }
                else if (StudentData[i] == '9')
                {
                    StudentData = StudentData.Replace("9", "");
                    i--;
                }
                else if (StudentData[i] == '0')
                {
                    StudentData = StudentData.Replace("0", "");
                    i--;
                }
                else if (StudentData[i] == ' ')
                {
                    StudentData = StudentData.Replace(" ", "");
                    i--;
                }
                else
                {

                }
            }
            return StudentData;
        }
    }
}
