using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Seniority { get; set; }

        public Worker() { }
        public Worker(string n, int a, int s)
        {
            Name = n;
            Age = a;
            Seniority = s;
        }
        public void Input()
        {
            Console.WriteLine("Enter the worker name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the worker Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the worker work experiance in years: ");
            Seniority = Convert.ToInt32(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {Name}, Age: {Age}, Experiance: {Seniority}");
        }

    }
}

