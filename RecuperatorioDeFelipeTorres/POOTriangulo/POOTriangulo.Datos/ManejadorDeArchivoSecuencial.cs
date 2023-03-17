using POOTriangulo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTriangulo.Datos
{
    public static class ManejadorDeArchivoSecuencial
    {
        private static string archivo = "Triangulos.txt";
        public static void GuardarEnArchivoSecuencial(List<Triangulo> lista)
        {
            using (var escritor=new StreamWriter(archivo))
            {
                foreach (var Triangulo in lista)
                {
                    string linea = ConstruirLinea(Triangulo);
                    escritor.WriteLine(linea);
                }
            }

        }
         private static string ConstruirLinea(Triangulo triangulo)
         {
            return $"{triangulo.LadoA}|{triangulo.LadoB}|{triangulo.LadoC}|{triangulo.Relleno.GetHashCode()}|{triangulo.Trazo.GetHashCode()}";
         }
        public static List<Triangulo> LeerArchiVoSecuencial()
        {
            List<Triangulo> lista = new List<Triangulo>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Triangulo triangulo = ConstruirTriangulo(linea);
                        lista.Add(triangulo);
                    }
                } 

            }
            return lista;
        }

        private static Triangulo ConstruirTriangulo(string linea)
        {
            //return new Triangulo() { LadoA = int.Parse(linea)};
            var campos = linea.Split('|');
            return new Triangulo()
            {
                LadoA = int.Parse(campos[0]),
                LadoB = int.Parse(campos[1]),
                LadoC = int.Parse(campos[2]),
                Relleno = (Color)int.Parse(campos[3]),
                Trazo=(Linea)int.Parse(campos[4])
            };
            
        }

       
    }
}
