using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED06_11_2023.Clases
{
	internal class Pila :listaEnlazadaSimple
	{
		public Pila()
		{
		}

		/*el push es como el insertar datos al frente de la lista*/

		public void Push(int datos)
		{
			InsertarFrenteLista(datos);
		}

		/*pop es como el eliminar alfrente de la lista*/
		public object Pop()
		{
			return EliminarDelFrente();
		}
		
	}
}
