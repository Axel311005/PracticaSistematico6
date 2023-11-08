using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int edad { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set;}
        public int nota3 { get; set;}
        public double promedio { get; set; }

        public Estudiante(string nombre, string apellido, int edad, int nota1, int nota2, int nota3, double promedio)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.edad = edad;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.promedio = promedio;
        }

        
    }
}
