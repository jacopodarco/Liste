using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLavoratoriListe
{
    class ListaLavoratori<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Nominativo { get; set; }
            public Node Next { get; set; }
            public Node(T nom)
            {
                Nominativo = nom;
                Next = null;
            }
        }
        private Node head;
        public ListaLavoratori()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Nominativo;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
