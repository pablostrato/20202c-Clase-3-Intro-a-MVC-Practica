using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class AlimentosServicio
    {
        private static List<Alimento> Lista = new List<Alimento>();

        public static List<Alimento> ObtenerTodos()
        {
            return Lista;
        }

        public static void Alta(Alimento ali)
        {
            int maxId = 0;
            if (Lista.Count > 0)
            {
                maxId = Lista.Max(o => o.Id);
            }

            ali.Id = maxId + 1;
            Lista.Add(ali);
        }

        public static void Editar(Alimento ali)
        {
            Alimento aliActual = ObtenerPorId(ali.Id);
            aliActual.Nombre = ali.Nombre;
            aliActual.Peso = ali.Peso;
        }

        public static Alimento ObtenerPorId(int Id)
        {
            return Lista.Find(o => o.Id == Id);
        }

        public static void Borrar(int Id)
        {
            Lista.RemoveAll(o => o.Id == Id);
        }
    }
}
