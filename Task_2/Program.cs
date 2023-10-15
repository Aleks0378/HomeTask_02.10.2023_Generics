using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створіть клас «Футбольна Команда». Клас має містити 
//інформацію про гравців футбольної команди. Реалізуйте 
//підтримку ітератора для класу «Футбольна Команда». 
//Протестуйте можливість використання foreach для класу 
//«Футбольна Команда».
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football_player[] f = new Football_player[8];
            f[0]=new Football_player("Heorhiy Bushchan", 29, "Dynamo Kyiv", 17);
            f[1] = new Football_player("Anatoliy Trubin", 22, "Benfica", 8);
            f[2] = new Football_player("Dmytro Riznyk", 24, "Shakhtar Donetsk", 2);
            f[3] = new Football_player("Mykola Matviyenko", 27, "Shakhtar Donetsk", 60);
            f[4] = new Football_player("Vitalii Mykolenko", 24, "Everton", 35);
            f[5] = new Football_player("Oleksandr Svatok", 29, "Dnipro-1", 3);
            f[6] = new Football_player("Oleksandr Zinchenko", 26, "Arsenal", 56);
            f[7] = new Football_player("Mykhailo Mudryk", 22, "Chelsea", 14);
            Ukraine_mens_national_team team = new Ukraine_mens_national_team(f);
            Console.WriteLine("\nUkraine men's national footbal team: ");
            foreach (Football_player item in f) item.Show();
            Console.WriteLine();
            foreach (Football_player item in team) item.Show();

        }
    }
}
