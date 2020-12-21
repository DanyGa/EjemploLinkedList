using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new LinkedList<string>();
            notas.AddFirst("do");
            notas.AddLast("so");

            notas.AddAfter(notas.First, "re");
            notas.AddAfter(notas.First.Next, "mi");
            notas.AddBefore(notas.Last, "fa");

            // Contenido: do re mi fa so

            notas.RemoveFirst();
            notas.RemoveLast();

            // Contenido: re mi fa

            LinkedListNode<string> nota = notas.Find("mi");
            notas.Remove(nota);
            notas.AddFirst(nota);

            // Contenido: mi re fa

            foreach (string n in notas)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
