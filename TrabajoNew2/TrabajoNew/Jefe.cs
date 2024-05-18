using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoNew
{
    internal class Jefe
    {
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; } // Gerente, Subgerente
        public string Area { get; set; } // Contabilidad, Planificación
        public int AnosAntiguedad { get; set; }

        public Jefe(string nombres, string dni, string cargo, string area, int anosAntiguedad)
        {
            Nombres = nombres;
            DNI = dni;
            Cargo = cargo;
            Area = area;
            AnosAntiguedad = anosAntiguedad;
        }

        public double CalcularSueldoBase()
        {
            if (Cargo == "Gerente")
            {
                return Area == "Contabilidad" ? 6000 : 7000;
            }
            else // Subgerente
            {
                return Area == "Contabilidad" ? 5000 : 6000;
            }
        }

        public double CalcularMovilidad()
        {
            return Cargo == "Gerente" ? 700 : 400;
        }

        public double CalcularBonificacion()
        {
            double sueldoBase = CalcularSueldoBase();
            if (AnosAntiguedad <= 7)
            {
                return sueldoBase * 0.05;
            }
            else // >= 8 años
            {
                return sueldoBase * 0.04;
            }
        }

        public double CalcularSueldoFinal()
        {
            return CalcularSueldoBase() + CalcularBonificacion() + CalcularMovilidad();
        }
    }
}
