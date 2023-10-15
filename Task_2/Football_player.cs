using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Football_player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Club { get; set; }
        public int Caps {  get; set; }

        public Football_player() { }
        public Football_player(string n, int a, string club, int caps) 
        {
            Name = n;
            Age = a;
            Club = club;
            Caps = caps;
        }
        public void Input()
        {
            Console.WriteLine("Enter the player name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the player Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player Club: ");
            Club = Console.ReadLine();
            Console.WriteLine("Enter the player Caps: ");
            Caps = Convert.ToInt32(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"\nName: {Name}, Age: {Age}, Club: {Club}, Caps: {Caps}");
        }

    }
}
