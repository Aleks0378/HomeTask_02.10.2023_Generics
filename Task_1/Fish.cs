using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Fish
    {
        string Common_name { get; set; }
        string Taxonomy { get; set; }
        bool Reef_safe { get; set; }
        string Description { get; set; }
        int Max_size { get; set; }

        public Fish() { }
        public Fish(string n, string t, bool r, string d, int m)
        {
            Common_name = n;
            Taxonomy = t;
            Reef_safe = r;
            Description = d;
            Max_size = m;
        }

        public void Input()
        {
            Console.WriteLine("Enter the fish Common name: ");
            Common_name = Console.ReadLine();
            Console.WriteLine("Enter the fish Taxonomy: ");
            Taxonomy = Console.ReadLine();
            string r = null;
            while (r != "Yes" || r != "No")
            {
                Console.WriteLine("Enter the fish Reef safe (Yes or No): ");
                r = Console.ReadLine();
                if (r == "Yes") Reef_safe = true;
                else if (r == "No") Reef_safe = false;
                else Console.WriteLine("Error! Enter proper data for the Reef safe.");
            }
            Console.WriteLine("Enter the fish Description: ");
            Description = Console.ReadLine();
            Console.WriteLine("Enter the fish Max size in cm: ");
            Max_size = Convert.ToInt32(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"\nCommon name: {Common_name}, Taxonomy: {Taxonomy}," +
                $" Reef_safe: {(true?"Yes":"No")}, Description: {Description}, Max size: {Max_size} cm");
        }

    }
}
