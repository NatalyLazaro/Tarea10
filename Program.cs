using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Colas
{
    class Program
    {
        //Hacer el ejercicio de capicua usando las estructuras de datos stack y queue
        private static bool valido(string numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }
        static void Main(string[] args)
        {

            // programa capicua
            bool capicua;
            string numero;
            
            Stack pila = new Stack();
            Queue circula_Cola = new Queue();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.Enqueue(c);
                        pila.Push(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)circula_Cola.Dequeue();
                        capicua = d.Equals(pila.Pop()); //compara la igualdad
                    } while (capicua && circula_Cola.Count!=0);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"njmero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                    // vaciar estructuras

                    circula_Cola.Clear();
                    pila.Clear();


                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }


        }

    }
}
