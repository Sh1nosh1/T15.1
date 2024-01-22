using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1.
                
                Write("Enter the number of students: ");
                int num1 = Convert.ToInt32(ReadLine());
                Students[] students = new Students[num1];
                for (int i = 0; i < students.Length; i++)
                {
                    Write("Enter name: ");
                    string name = ReadLine();
                    Write("Enter surname: ");
                    string surname = ReadLine();
                    Write("Enter gender M or F (male or female): ");
                    string gender = ReadLine();
                    Write("Enter year of birth: ");
                    int year = Convert.ToInt32(ReadLine());
                    students[i] = new Students(name, surname, gender, year);
                    WriteLine();
                }
                WriteLine($"Number of boys: {Students.c_male}\nNumber of girls: {Students.c_female}\nTotal number: {Students.count}\n");
                WriteLine("Boys: \n");
                foreach (var student in students)
                {
                    if (student.Gender == "Male")
                    {
                        student.Output();
                    }
                }
                WriteLine("Girls: \n");
                foreach (var student in students)
                {                    
                    if (student.Gender == "Female")
                    {
                        student.Output();
                    }
                }

                //Task 2.
                
                Write("Enter the number of sportsmens: ");
                int num2 = Convert.ToInt32(ReadLine());
                Sportsmens[] sportsmens = new Sportsmens[num2];
                for (int i = 0; i < sportsmens.Length; i++)
                {
                    Write("Enter name: ");
                    string name = ReadLine();
                    Write("Enter surname: ");
                    string surname = ReadLine();
                    Write("Enter tall in cm: ");
                    double tall = Convert.ToDouble(ReadLine());
                    Write("Enter weight in kg: ");
                    double weight = Convert.ToDouble(ReadLine());
                    sportsmens[i] = new Sportsmens(name, surname, tall, weight);
                    WriteLine();
                }
                WriteLine($"Total number: {Sportsmens.Count}\nUnsuitable weight: {Sportsmens.C_w}\n");
                Write("Information on all: \n");
                foreach (var sportsmen in sportsmens)
                {
                    sportsmen.Output();
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
