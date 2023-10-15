using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Створіть клас «Кафе» з інформацією про працівників кафе.
//Реалізуйте підтримку ітератора для класу «Кафе».
//Протестуйте можливість використання foreach для «Кафе».

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] w = new Worker[8];
            w[0] = new Worker("Heorhiy Bushchan", 29, 10);
            w[1] = new Worker("Anatoliy Trubin", 22, 3);
            w[2] = new Worker("Dmytro Riznyk", 24, 2);
            w[3] = new Worker("Mykola Matviyenko", 27, 6);
            w[4] = new Worker("Vitalii Mykolenko", 24, 5);
            w[5] = new Worker("Oleksandr Svatok", 29, 3);
            w[6] = new Worker("Oleksandr Zinchenko", 26, 6);
            w[7] = new Worker("Mykhailo Mudryk", 22, 4);
            Console.WriteLine("\nAll Cafe workers: ");
            foreach (Worker item in w) item.Show();
            Console.WriteLine();
            Cafe team = new Cafe(w);
            foreach (Worker item in team) item.Show();
        }
    }
}
