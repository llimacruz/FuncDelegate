using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //using external function
            Func<string> greetings = GoodMorning;
            string goodmorning = greetings();
            Console.WriteLine(goodmorning);


            //using external function with parameters
            Func<double, double, double> Calculate = Add;
            double sum = Calculate(1.1, 2.2);
            Console.WriteLine(sum);


            //using anonymous method
            Func<int, bool> isPosivite = delegate (int number)
            {
                return number > 0;
            };
            Console.WriteLine(isPosivite(9));


            //using anonymous method with lambda
            Func<int, bool> isPositiveLambda1 = (int number) =>
            {
                return number > 0;
            };
            Console.WriteLine(isPositiveLambda1(9));


            //using anonymous method with lambda in line
            Func<int, bool> isPositiveLambda2 = number => number > 0;
            Console.WriteLine(isPositiveLambda2(7));


            //using anonymous method with lambda and a little bit more
            Func<Student, string> checkName1 = student =>
            {
                if (student.Name.StartsWith("L"))
                    return student.Name;
                else
                    return "wrong name 1";
            };
            Console.WriteLine(checkName1(new Student { Id = 1, Name = "Leo" }));
            Console.WriteLine(checkName1(new Student { Id = 1, Name = "Luiza" }));
            Console.WriteLine(checkName1(new Student { Id = 1, Name = "Clara" }));


            //using anonymous method with lambda and a little bit more in line
            Func<Student, string> checkName2 = student => student.Name.StartsWith("L") ? student.Name : "wrong name 2";
            Console.WriteLine(checkName2(new Student { Id = 1, Name = "Leo" }));
            Console.WriteLine(checkName2(new Student { Id = 1, Name = "Luiza" }));
            Console.WriteLine(checkName2(new Student { Id = 1, Name = "Clara" }));
        }

        private static string GoodMorning()
        {
            return "Good Morning";
        }

        private static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
