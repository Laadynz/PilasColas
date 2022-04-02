using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas() 
        {
            lista = new List<string>();
        }

        public void Agregar(string dato) 
        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            if (lista.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Eliminar() 
        {
            if (ValidaVacio()) 
            {
                throw new Exception("Lista Vacia");
            }
            lista.RemoveAt(lista.Count - 1);

        }

        public string Imprimir() 
        {
            string datos = "";

            if (ValidaVacio()) 
            {
                return "Lista Vacia";
            }

            int lstCount = lista.Count;
            for (int i = 0; i < lstCount; i++) 
            {
                if (i > 0) 
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {lista[i]}";
            }

            return datos;
        }
    }
}
