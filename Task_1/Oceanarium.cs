using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Oceanarium : IEnumerator
    {
        public Fish[] fishes;

        public object Current => throw new NotImplementedException();

        public Oceanarium(int quant)
        {
            fishes = new Fish[quant];
            for (int i = 0; i < quant; i++) fishes[i] = new Fish();
        }
        public Oceanarium() : this(1) { }
        public Oceanarium(Fish[] fishes)
        {
            this.fishes = fishes;
        }

        public void InputOceanarium()
        {
            for (int i = 0; i < fishes.Length; i++) fishes[i].Input();
        }
        public void ShowOceanarium()
        {
            for (int i = 0; i < fishes.Length; i++) fishes[i].Show();
        }

        public IEnumerator GetEnumerator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nList of all Fishes of the Oceanarium:\n");
            Console.ForegroundColor= ConsoleColor.Green;
            for (int i = 0;i < fishes.Length;i++) yield return fishes[i];
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
