using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ED06_11_2023.Clases
{
    public class listaEnlazadaSimple
    {
         Nodo primero;
         Nodo ultimo;


        //lista vacia
        public listaEnlazadaSimple()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if(primero == null )
            {
                return true;
            }
            return false;

            /*otra forma de hacerlo es con operador ternario solo se puede tener dos opciones
                return primero == null ? false : true;
             */
        }

        public int Longitud()
        {
            int contador = 0;
            if (ListaVacia())
            {
                return contador;
            }
            else
            {
                //saber que es el primer valor y el ultimo
                if(primero != null && primero.getSiguiente != null)
                {
                    return ++contador;
                    //o (contador+1)
                }
                else
                {
                    Nodo actual = primero;
                    while(actual.getSiguiente != null)
                    {
                        contador++;
                        actual = actual.getSiguiente();

                    }
                    return contador + 1;
                }
            }
            return 0;
        }

        public void InsertarAlFrente(int elemento)
        {
            /*los estados de la lista vacia, un elemento y llena*/
            if(ListaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
        }
    }
}
