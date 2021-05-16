using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected object[] ListaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }
        public bool colaLLena()
        {
            return fin == MAXTAMQ - 1;
        }
        //operaciones para trabajar con datos en la cola
        public void insertar(object elemento)
        {
            if (!colaLLena())
            {
                ListaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }


        public object quitar()
        {
            if (!colaVacia())
            {
                return ListaCola[frente++];
            }
            else
            {
                throw new Exception("cola Vacia");
            }
        }
        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin= - 1;
        }
        //acceso a la cola
        public object frenteCola()
        {
            if (!colaVacia())
            {
                return ListaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }
    }
}
