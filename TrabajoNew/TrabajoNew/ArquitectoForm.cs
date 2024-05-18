using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoNew
{
    public partial class ArquitectoForm : Form
    {
        public ArquitectoForm()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cbCondicionContrato.SelectedItem.ToString();
            string especialidad = cbEspecialidad.SelectedItem.ToString();
            string tipoActividad = cbTipoActividad.SelectedItem.ToString();
            string tipoAfiliacion = cbTipoAfiliacion.SelectedItem.ToString();

            Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);

            double sueldoBase = arquitecto.CalcularSueldoBase();
            double bonificacion = arquitecto.CalcularBonificacion();
            double descuento = arquitecto.CalcularDescuento();
            double sueldoBruto = arquitecto.CalcularSueldoBruto();
            double sueldoNeto = arquitecto.CalcularSueldoNeto();

            lblSueldoBase.Text = $"Sueldo Base: {sueldoBase:C}";
            lblBonificacion.Text = $"Bonificación: {bonificacion:C}";
            lblDescuento.Text = $"Descuento: {descuento:C}";
            lblSueldoBruto.Text = $"Sueldo Bruto: {sueldoBruto:C}";
            lblSueldoNeto.Text = $"Sueldo Neto: {sueldoNeto:C}";

        }
    }
}
