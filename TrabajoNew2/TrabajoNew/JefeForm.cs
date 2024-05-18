using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TrabajoNew
{
    public partial class JefeForm : Form
    {
        public JefeForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string dni = txtDNI.Text;
            string cargo = cbCargo.SelectedItem.ToString();
            string area = cbArea.SelectedItem.ToString();
            int anosAntiguedad = int.Parse(txtAnosAntiguedad.Text);

            Jefe jefe = new Jefe(nombres, dni, cargo, area, anosAntiguedad);

            double sueldoBase = jefe.CalcularSueldoBase();
            double movilidad = jefe.CalcularMovilidad();
            double bonificacion = jefe.CalcularBonificacion();
            double sueldoFinal = jefe.CalcularSueldoFinal();

            lblSueldoBase.Text = $"Sueldo Base: {sueldoBase:C}";
            lblMovilidad.Text = $"Movilidad: {movilidad:C}";
            lblBonificacion.Text = $"Bonificación: {bonificacion:C}";
            lblSueldoFinal.Text = $"Sueldo Final: {sueldoFinal:C}";
        }
    }
}
