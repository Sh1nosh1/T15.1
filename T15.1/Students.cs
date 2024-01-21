using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T15._1
{
    class Students
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;

        public string Name { get => (name != "" && name != " ")? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Surname
        /// </summary>
        private string surname;
        public string Surname { get => (surname != "" && surname != " ") ? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// Gender
        /// </summary>
        private string gender;
        public string Gender { get => (gender == "M")? "Male" : "Female"; set => gender = value; }
        /// <summary>
        /// Year of birth
        /// </summary>
        private int year;
        public int Year { get => (year < 2018)? year : 0; set => year = value; }
        /// <summary>
        /// Boy's counter
        /// </summary>
        private static int c_male;
        public static int C_male { get => c_male; set => c_male = value; }
        /// <summary>
        /// Girl's counter
        /// </summary>
        private static int c_fem;
        public static int C_fem { get => c_fem; set => c_fem = value; }
        /// <summary>
        /// Total number
        /// </summary>
        private static int count;
        public static int Count { get => count; set => count = value; }

        
        /// <summary>
        /// Constr. without parameters
        /// </summary>
        public Students () { }
        /// <summary>
        /// Constr. with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="gender"></param>
        /// <param name="year"></param>
        public Students(string name, string surname, string gender, int year)
        {
            this.Name = name; this.Surname = surname; this.Gender = gender; this.Year = year;
            if(gender == "Male")
            {
                C_male++;
            }
            else if(gender == "Female")
            {
                C_fem++;
            }
            count++;
        }
        /// <summary>
        /// Static constr.
        /// </summary>
        static Students()
        {
            C_male = 0;
            C_fem = 0;
            count = 0;
        }
        /// <summary>
        /// Output
        /// </summary>
        public static void Output()
        {
            WriteLine($"Name: {Name}\nSurname: {Surname}\nGender: {Gender}\nYear of birth: {Year}\nNumber of girls: {C_fem}\nNumber of boys: {C_male}\nTotal number: {count}");
        }



    }
}
