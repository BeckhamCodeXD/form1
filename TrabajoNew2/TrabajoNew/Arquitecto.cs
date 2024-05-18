using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoNew
{
    internal class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; } 
        public string Especialidad { get; set; } 
        public string TipoActividad { get; set; } 
        public string TipoAfiliacion { get; set; } 

        public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
        }

        public double CalcularSueldoBase()
        {
            if (CondicionContrato == "Estable")
            {
                return TipoActividad == "Supervisión de Obras" ? 4000 : 6000;
            }
            else
            {
                return TipoActividad == "Supervisión de Obras" ? 2000 : 4500;
            }
        }

        public double CalcularBonificacion()
        {
            double sueldoBase = CalcularSueldoBase();
            if (Especialidad == "Estructuras")
            {
                return sueldoBase * 0.16;
            }
            else
            {
                return sueldoBase * 0.18;
            }
        }

        public double CalcularDescuento()
        {
            double sueldoBase = CalcularSueldoBase();
            return TipoAfiliacion == "AFP" ? sueldoBase * 0.15 : sueldoBase * 0.08;
        }

        public double CalcularSueldoBruto()
        {
            return CalcularSueldoBase() + CalcularBonificacion();
        }

        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularDescuento();
        }
    }
}
