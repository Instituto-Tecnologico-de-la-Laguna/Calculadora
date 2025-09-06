using Calculadora.Utilidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nombre:" + dgrDatos[0, 0].Value.ToString());

            try {
                var BaseDatos = CargarDatos();
                if (sfvBDJason.ShowDialog() == DialogResult.OK)
                {
                    GuardarJason(BaseDatos);
                }
                    }
            catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message, "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private BaseDatosJson CargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in dgrDatos.Rows){
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[1].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[2].Value?.ToString()??"";
                    

                }
                registros.Personas.Add(persona);
            }
            registros.TotalRegistros = registros.Personas.Count;
            return registros;
        }
        private void GuardarJason(BaseDatosJson Lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,

            };
            string json = JsonConvert.SerializeObject(Lista, caracteristicas);
            File.WriteAllText(sfvBDJason.FileName, json);
        }
    }
}
