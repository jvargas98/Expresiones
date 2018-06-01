using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones
{
    class Nodo
    {
        private char _valor;
        private Nodo izquierdo;
        private Nodo derecho;
        private Nodo siguiente;
        private Nodo anterior;

        public char Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Nodo Izquierdo
        {
            get { return izquierdo; }
            set { izquierdo = value; }
        }

        public Nodo Derecho
        {
            get { return derecho; }
            set { derecho = value; }
        }
        public Nodo Siguente {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo Anterior {
            get { return anterior; }
            set { anterior = value; }
        }


        public Nodo(char valor)
        {
            _valor = valor;
        }
        public override string ToString()
        {
            string cadena = "";
            cadena = "Valor: " + _valor;
            return cadena;
        }


    }
}
