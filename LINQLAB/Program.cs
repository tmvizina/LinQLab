using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 11, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy",13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah",53));
            students.Add(new Student("Hannibal",15));
            students.Add(new Student("Phillip",16));
            students.Add(new Student("Maria",63));
            students.Add(new Student("Abe",33));
            students.Add(new Student("Curtis",10));

            //For Numbers

            //1). Find the Minimum Value of nums

            int minnum = nums.Min();
            Console.WriteLine("1)"+ minnum);

            //2) Find the Maximum Value of nums

            int maxnum = nums.Max();

            Console.WriteLine("2)" + maxnum);

            //3) Find the Maximum Value such that value less than 10,000

            int maxunder1000 = nums.Where(num => num < 10000).Max();

            Console.WriteLine("3)" + maxunder1000);

            //4) Find All Values such that value between 10 and 100

            List<int> between10and100 = nums.Where(num => num > 10 && num < 100).ToList();

            Console.WriteLine("4)");
            for (int i = 0; i < between10and100.Count; i++)
            {
                Console.WriteLine(between10and100[i]);
            }

            //5) Find All values such that value between 100,000 and 999,999

            List<int> between100000and999999 = nums.Where(num => num > 100000 && num < 999999).ToList();


            Console.WriteLine("5)");
            for (int i = 0; i < between100000and999999.Count; i++)
            {
                Console.WriteLine(between100000and999999[i]);
            }


            //6 Count All even values

            List<int> EvenNums = nums.Where(num=>num % 2 == 0).ToList();

            int numberofevenvalues = EvenNums.Count;

            Console.WriteLine("6)" + numberofevenvalues);

            //------------------------------------------------------------------------------------------

            //1) Find All Students over Age of 21

            List<Student> studentsover21 = students.Where(s => s.Age >= 21).ToList();

            Console.WriteLine("1) Students over 21");

            for (int i = 0; i < studentsover21.Count; i++)
            {
                Console.WriteLine(students[i].Name);
            }

            //2) Find the oldest Student

            Console.WriteLine("2) Oldest Student");
            int OldestStudentAge = students.Max(s => s.Age);

            List<Student> oldeststudents = students.Where(s=>s.Age==OldestStudentAge).ToList();

            for (int i = 0; i < oldeststudents.Count; i++)
            {
                Console.WriteLine(oldeststudents[i].Name);
            }


            Console.WriteLine("3) Youngest Student");
            //3) Find the youngest student
            int YoungestStudentAge = students.Min(s => s.Age);

            List<Student> youngeststudents = students.Where(s => s.Age == YoungestStudentAge).ToList();

            for (int i = 0; i < youngeststudents.Count; i++)
            {
                Console.WriteLine(youngeststudents[i].Name);
            }



            //4) Find the oldest student such that age less than 25

            Console.WriteLine("4) Oldest Student less than 25");

            List<Student> studentsunder25 = students.Where(s => s.Age < 25).ToList();

            int oldestunder25 = studentsunder25.Max(s => s.Age);

            List<Student> oldeststudentsunder25 = studentsunder25.Where(s => s.Age == oldestunder25).ToList();

            for (int i = 0; i < oldeststudentsunder25.Count; i++)
            {
                Console.WriteLine(oldeststudentsunder25[i].Name);
            }

            //5) Find All students such that &2=0 and age over 21

            List<Student> evenstudentover21 = students.Where(s => s.Age > 21 && s.Age % 2 == 0).ToList();

            Console.WriteLine("5) All even students over 21");

            for (int i = 0; i < evenstudentover21.Count; i++)
            {
                Console.WriteLine(evenstudentover21[i].Name);
            }

            //6) Find all students such that age between 13 and 19 inclusive


            List<Student> teenstudents = students.Where(s => s.Age >= 13 && s.Age <= 19).ToList();

            Console.WriteLine("6) All teenage Students");

            for (int i = 0; i < teenstudents.Count; i++)
            {
                Console.WriteLine(teenstudents[i].Name);
            }
            //7) Find all students whose name starts with a Vowel

            Console.WriteLine("7) Vowel First letter Students");
            List<Student> firstnamevowels = students.Where(s => s.Name[0]== 'A'||s.Name[0]=='E'|| s.Name[0] =='I'|| s.Name[0] =='O'|| s.Name[0] =='U').ToList();

            for (int i = 0; i < firstnamevowels.Count; i++)
            {
                Console.WriteLine(firstnamevowels[i].Name);
            }
        }
    }
}
