using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string add = "Y";
            while (add == "Y")
            {
                student student = new student();
                Console.WriteLine("Enter student name :- ");
                student.name = Console.ReadLine();
                Console.WriteLine("Enter student grade:-");
                student.grade = float.Parse(Console.ReadLine());
                if(student.grade<60)
                {
                    Console.WriteLine(student.name + " is failed");
                }
                else
                {
                    if( student.grade <=100)
                    {
                        Console.WriteLine(student.name + " is passed");
                    }
                }
                if(student.grade >100)
                {
                    Console.WriteLine("sorry the grade is invalid");
                }
            
                Console.WriteLine("do you want to add another student");
                Console.WriteLine("press Y to add new student");

                add = Console.ReadLine().ToUpper();

            }


            Console.ReadKey();



        }
        class student
        {
            public string name
            {
                get; set;

            }
            public float grade
            {
                get;
                set;
            }
         
        }

    }
}
