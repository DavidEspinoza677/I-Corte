using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;

        public Form1()
        {
            InitializeComponent();

            
            registro = new Registro();

           
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string ciudad = cmbCiudad.Text;  

            
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(ciudad))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            
            Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            registro.AgregarPersona(nuevaPersona);
            MessageBox.Show("Persona agregada exitosamente.");
        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
           
            Persona persona = registro.ObtenerUltimaPersona();

            if (persona != null)
            {
               
                int edad = Operacion.CalcularEdad(persona);
                bool mayorDeEdad = Operacion.EsMayorDeEdad(persona);

               
                string resultado = $"La persona tiene {edad} años y es " +
                                   (mayorDeEdad ? "mayor" : "menor") + " de edad.";
                lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }
    }

}
