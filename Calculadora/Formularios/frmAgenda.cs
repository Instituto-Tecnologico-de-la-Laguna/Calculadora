using Calculadora.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //MessageBox.Show("Nombre: "+dgvDatos[0, 0].Value.toString());
            try
            {
                var BaseDatos = CargarDatos();
                if (sfvBDJson.ShowDialog() == DialogResult.OK)
                {
                    //Guardar Json
                    GuardarJson(BaseDatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void GuardarJson(BaseDatosJson lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };

            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(sfvBDJson.FileName, json);
        }

        private BaseDatosJson CargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach(DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString();
                    persona.telefono = fila.Cells[1].Value?.ToString();
                    persona.correo = fila.Cells[2].Value?.ToString();
                }
                registros.Personas.Add(persona);
            }
            registros.TotalRegistros = registros.Personas.Count;
            return registros;
        }
    }
}
