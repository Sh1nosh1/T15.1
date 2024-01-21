using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T15._1
{
    class Sportsmens
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;

        public string Name { get => (name != "" && name != " ") ? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Surname
        /// </summary>
        private string surname;
        public string Surname { get => (surname != "" && surname != " ") ? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// Tall
        /// </summary>
        private double tall;
        public double Tall { get => (tall > 0)? tall : 0; set => tall = value; }
        /// <summary>
        /// Weight
        /// </summary>
        private double weight;
        public double Weight { get => (weight > 0)? weight : 0; set => weight = value; }
        /// <summary>
        /// Unsuitable weight counter
        /// </summary>
        private static int c_w;
        public static int C_w { get => c_w; set => c_w = value; }
        /// <summary>
        /// Total number
        /// </summary>
        private static int count;
        public static int Count { get => count; set => count = value; }
        /// <summary>
        /// Constr. without parameters
        /// </summary>
        public Sportsmens() { }
        /// <summary>
        /// Constr. with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="tall"></param>
        /// <param name="weight"></param>
        public Sportsmens(string name, string surname, double tall, double weight)
        {
            this.Name = name; this.Surname = surname; this.Tall = tall; this.Weight = weight;
            count++;
            if(weight > 70) { C_w++; }
        }
        /// <summary>
        /// Static constr.
        /// </summary>
        static Sportsmens() { C_w = 0; Count++; }
        /// <summary>
        /// Output
        /// </summary>
        public static void Output()
        {
            WriteLine($"Name: {Name}\nSurname: {Surname}\nTall: {Tall}\nWeight: {Weight}\nUnsuitable weight: {C_w}\nTotal number: {count}");
        }
    }
}
