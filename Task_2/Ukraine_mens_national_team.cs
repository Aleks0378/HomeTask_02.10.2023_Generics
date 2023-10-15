using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Ukraine_mens_national_team: IEnumerator
    {
        Football_player[] players;

        object IEnumerator.Current => throw new NotImplementedException();

        public Ukraine_mens_national_team(int quant)
        {
            players = new Football_player[quant];
            for (int i = 0; i < quant; i++) players[i] = new Football_player();
        }
        public Ukraine_mens_national_team(): this(1) { }
        public Ukraine_mens_national_team(Football_player[] players)
        {
            this.players = players;
        }
        public void Input()
        {
            for (int i = 0; i < players.Length; i++) players[i].Input();
        }
        public void Show()
        {
            for (int i = 0; i < players.Length; i++) players[i].Show();
        }

        public IEnumerator GetEnumerator()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nList of all players of the Ukraine men's national team:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < players.Length; i++) yield return players[i];
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
