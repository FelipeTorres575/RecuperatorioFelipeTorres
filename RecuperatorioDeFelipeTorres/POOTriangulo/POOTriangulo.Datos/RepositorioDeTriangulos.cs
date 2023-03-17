using POOTriangulo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTriangulo.Datos
{
    public class RepositorioDeTriangulos
    {
        private List<Triangulo> listaTriangulo;
        public RepositorioDeTriangulos()
        {
            listaTriangulo = new List<Triangulo>();

            //var tri1 = new Triangulo(10, 10, 10);
            //var tri2 = new Triangulo(20, 20, 20);
            //var tri3 = new Triangulo(30, 30, 30);
            //var tri4 = new Triangulo(40, 40, 40);
            //Agregar(tri1);
            //Agregar(tri2);
            //Agregar(tri3);
            //Agregar(tri4);
            listaTriangulo = ManejadorDeArchivoSecuencial.LeerArchiVoSecuencial();
        }
        public void Agregar(Triangulo TriNuevo)
        {
            listaTriangulo.Add(TriNuevo);
        }
        public int GetCantidad()
        {
            return listaTriangulo.Count();
        }
        public List<Triangulo> GetLista()
        {
            return listaTriangulo;
        }

        public bool Borrar(Triangulo tri)
        {
            if (listaTriangulo.Contains(tri))
            {
                listaTriangulo.Remove(tri);
                return true;
            }
            return false;
        }
    }
}
