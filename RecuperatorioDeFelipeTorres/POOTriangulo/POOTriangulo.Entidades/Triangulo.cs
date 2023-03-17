using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTriangulo.Entidades
{
    public class Triangulo
    {
        //Atributos
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public Color Relleno { get; set; }
        public Linea Trazo { get; set; }
        //Constructor
        public Triangulo()
        {
                
        }

        public Triangulo(int ladoA ,int ladoB ,int ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }
        //Metodos
        public double GetPerimetro() => LadoA + LadoB + LadoC;
        public double SemiPerimetro() => (LadoA + LadoB + LadoC) / 2;
        public double GetArea() {
            double S = SemiPerimetro();
            return Math.Sqrt(S * (S-LadoA)*(S-LadoB)*(S-LadoC));
        } 

    }
}
