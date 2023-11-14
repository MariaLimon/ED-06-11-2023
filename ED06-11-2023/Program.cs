// See https://aka.ms/new-console-template for more information
using ED06_11_2023.Clases;

/*
listaEnlazadaSimple lista = new listaEnlazadaSimple();
lista.InsertarFrenteLista(40);
lista.InsertarFrenteLista(30);
lista.InsertarFrenteLista(20);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);
lista.InsertarFrenteLista(10);


lista.ImprimirLista();
Console.WriteLine("-----------");
lista.InsertarMedioLista(7);
lista.ImprimirLista();
*/

Pila pila = new Pila();
int numero = 0;
int numero1 = 1;
int numero2 = 2;

pila.Push(numero);
pila.ImprimirLista();
pila.Push(numero1);
pila.ImprimirLista();
pila.Push(numero2);
pila.ImprimirLista();
Console.WriteLine("-----------");
pila.Pop();
pila.ImprimirLista();
