using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expresiones
{
    class Expresion
    {
        private Nodo inicio;
        private Nodo ultimo;
        private string recorrido;

        public Nodo Inicio
        {
            get { return inicio; }
        }
        public string Recorrido
        {
            get { return recorrido; }
            set { recorrido = value; }
        }

        public void LeerExpresion(string expresion)
        {
            string[] valores = new string[20];
            valores = expresion.Split(' ');
            for (int i = 0; i < valores.Length; i++)
            {
                Nodo nuevo = new Nodo(Convert.ToChar(valores[i]));
                Agregar(nuevo);
            }
            Generar();
        }

        public void Agregar(Nodo nuevo)
        {
           if(inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
            
        }

        public void Generar()
        {
            Nodo aux = inicio;
            while(aux != null)
            {
                if ((aux.Valor == 42 || aux.Valor == 47))
                {
                    aux.Derecho = aux.Siguente;
                    aux.Izquierdo = aux.Anterior;

                    if (aux.Siguente.Siguente != null)
                        aux.Siguente.Siguente.Anterior = aux;
                    else
                        aux.Siguente.Siguente = null;

                    if (aux.Anterior.Anterior != null)
                        aux.Anterior.Anterior.Siguente = aux;
                    else
                        aux.Anterior = null;

                    aux.Siguente = aux.Siguente.Siguente;

                    if (aux.Anterior != null)
                        aux.Anterior = aux.Anterior.Anterior;
                    else
                        aux.Anterior = null;
                }
                aux = aux.Siguente;
            }
            aux = inicio;
            while (aux != null)
            {
                if (aux.Valor == 43 || aux.Valor == 45)
                {
                    aux.Derecho = aux.Siguente;
                    aux.Izquierdo = aux.Anterior;


                    if(aux.Siguente.Siguente != null)
                        aux.Siguente.Siguente.Anterior = aux;
                    else
                    {
                        aux.Siguente.Siguente = null;
                    }

                    if (aux.Anterior.Anterior != null)
                        aux.Anterior.Anterior.Siguente = aux;
                    else
                        aux.Anterior = null;

                    aux.Siguente = aux.Siguente.Siguente;

                    if (aux.Anterior != null)
                        aux.Anterior = aux.Anterior.Anterior;
                    else
                        aux.Anterior = null;
                    inicio = aux;
                }
                aux = aux.Siguente;
            }
        }

        public void RecorridoPreOrden(Nodo inicio)
        {
            if(inicio != null)
            {
                recorrido += Convert.ToString(inicio.Valor);
                RecorridoPreOrden(inicio.Izquierdo);
                RecorridoPreOrden(inicio.Derecho);
            }    
        }

        public void RecorridoPosOrden(Nodo inicio)
        {
            if(inicio != null)
            {
                RecorridoPosOrden(inicio.Izquierdo);
                RecorridoPosOrden(inicio.Derecho);
                recorrido += inicio.Valor;
            }
        }


        public string mostrar()
        {
            return recorrido;
        }
    }
}
