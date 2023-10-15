using System;
using System.Collections;
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
    internal class Cafe: IEnumerator
    {
       Worker[] workers;

        object IEnumerator.Current => throw new NotImplementedException();

        public Cafe(int quant)
        {
            workers = new Worker[quant];
            for (int i = 0; i < quant; i++) workers[i] = new Worker();
        }
        public Cafe() : this(1) { }
        public Cafe(Worker[] workers)
        {
            this.workers = workers;
        }
        public void Input()
        {
            for (int i = 0; i < workers.Length; i++) workers[i].Input();
        }
        public void Show()
        {
            for (int i = 0; i < workers.Length; i++) workers[i].Show();
        }

        public IEnumerator GetEnumerator()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nList of all workers of the Cafe:");
            for (int i = 0; i < workers.Length; i++) yield return workers[i];
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
