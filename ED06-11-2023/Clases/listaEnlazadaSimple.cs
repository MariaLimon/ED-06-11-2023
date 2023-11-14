using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
				Nodo actual = primero;
                if (actual.getSiguiente == null)
                {
                    return ++contador;
                    //o (contador+1)
                }
                else
                {

                    while (actual.getSiguiente != null)
                    {
                        contador++;
                        actual = actual.getSiguiente();

                    }
                    return contador + 1;
                }
			}
        }
        
        public void ImprimirLista()
        {
            if(ListaVacia())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
				Nodo actual = primero;
				while (actual != null)
				{
					Console.WriteLine($"{actual.getDatos()}->");
					actual = actual.getSiguiente();
				}
                Console.WriteLine("->null");
			}
        }



        //buscar un elemento especifico en la lista
        public void BuscarElemento(int elementoBuscado)
        {
            int centinela = -1;
            //Nodo elemento = elementoBuscado;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                //Console.WriteLine("dame el numero que buscas");
                Nodo actual = primero;
                while( actual != null)
                {
                    if (actual.getDatos() == elementoBuscado)
                    {
                        centinela = 1;
                        Console.WriteLine("el elemento se encuentra en la lista");
                        break;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
				}
                if (centinela == -1)
                {
					Console.WriteLine("el elemento NO encuentra en la lista");
				}
            }
        }
		//mostrar la posicion de un elemento
		public void PosicionElemento(int elementoBuscado)
		{
			//Nodo elemento = elementoBuscado;
			if (ListaVacia())
			{
				Console.WriteLine("La lista esta vacia");
			}
			else
			{
                int centinela = -1;
                int contador = 0;
                Nodo actual = primero;
                while(actual != null)
                {
					if (actual.getDatos() == elementoBuscado)
					{
						centinela = 0;
						Console.WriteLine($"el elemento se encuentra en la posicion {contador} de la lista");
						break;
					}
					else
					{
						actual = actual.getSiguiente();
                        contador++;
					}
				}
				if (centinela == -1)
				{
					Console.WriteLine("el elemento NO encuentra en la lista");
				}
			}
		}
        //insertar un numero al frente de la lista
        public void InsertarFrenteLista(int elemento)
        {
            /*los estados de la lista vacia, un elemento y llena*/
            if (ListaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
            else
            {
                primero = new Nodo(elemento, primero);
            }
        }
        //insertar en el medio de la lista
        public void InsertarMedioLista(int dato)
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                primero = ultimo = new Nodo(dato);
            }
            else
            {
                int logitud = Longitud();
                Nodo actual = primero;
                int iterador = 1;
                Nodo anterior = null;
                while (actual.getSiguiente() != null && iterador < logitud / 2)
                {
					iterador++;
					actual = actual.getSiguiente();
					
				}
				anterior = actual;
                Nodo nuevo = new Nodo(dato,actual.getSiguiente());

				anterior.setSiguiente(nuevo);
			}
        }


		public object EliminarDelFrente()
		{
			if (ListaVacia())
			{
				object eliminarElemento = primero.getDatos(); // recupera los datos

				// restablece las referencias primerNodo y ultimoNodo
				if (primero == ultimo)
					primero = ultimo = null;
				else
				{
					primero = primero.getSiguiente();
				}

				return eliminarElemento; // devuelve los datos eliminados
			}

			return null; // Return null or handle differently if the list is empty
		}

	}
}
