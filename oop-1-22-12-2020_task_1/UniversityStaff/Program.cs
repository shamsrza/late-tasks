using System;

namespace staffInfo
{
    public enum UniversityStaff : byte
    {
        Student = 1,
        Teacher,
        Lecturer,
        Professor
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            TimeSpan start = new TimeSpan(6, 0, 0); //6 o'clock
            TimeSpan middle = new TimeSpan(11, 0, 0); //11 o'clock
            TimeSpan end = new TimeSpan(18, 0, 0); //18 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter your father's name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Select index of your role: 1. Student ; 2.Teacher; 3.Lecturer; 4.Professor");
            int roleIndex = Convert.ToInt32(Console.ReadLine());
            string message, greetingWord;

            switch (roleIndex)
            {
                case 1:
                    message = $"Welcome to our university {name} {surname} {fatherName} !";
                    Console.WriteLine(message);
                    break;
                case 2:
                    message = "Our university is the best place for self-developing you as a teacher!";
                    Console.WriteLine(message);
                    break;
                case 3:
                    message = $"Welcome back, {name}! Students are waiting for your lectures :)";
                    Console.WriteLine(message);
                    break;
                case 4:
                    if (now >= start && now <= middle)
                    {
                        greetingWord = "Good Morning";
                    }
                    else if (now >= middle && now <= end)
                    {
                        greetingWord = "Good Afternoon";
                    }
                    else
                    {
                        greetingWord = "Good Evening";
                    }
                    message = $"{greetingWord} Professor!";
                    Console.WriteLine(message);
                    break;
            }
           
        }
    }
}
