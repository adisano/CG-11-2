using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the class Logic
            Logic logic = new Logic();
            //use the method Run() within the class Logic
            logic.Run();
            //keep the program open after Run() is finished
            Console.ReadLine();
        }
    }
}
