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
using Calculadora.Utilities;
using Newtonsoft.Json;

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
            //MessageBox.Show("Nombre: " + dgvDatos[0, 0].Value.ToString());
            try
            {
                var BaseDatos = CargarDatos();
                if (sfdBDJson.ShowDialog() == DialogResult.OK)
                {
                    //Guardar Json
                    GuardarJson(BaseDatos);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BaseDatosJson CargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? string.Empty;
                    persona.telefono = fila.Cells[1].Value?.ToString() ?? string.Empty;
                    persona.correo = fila.Cells[2].Value?.ToString() ?? string.Empty;
                }
                registros.personas.Add(persona);
            }
            registros.TotalRegistros = registros.personas.Count;
            return registros;
        }

        private void GuardarJson(BaseDatosJson lista)//Guardar
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(sfdBDJson.FileName, json);
        }

        private void btnCargar_Click(object sender, EventArgs e)//Cargar
        {
            if (ofdBDJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofdBDJson.FileName);
                    var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    cargarRegistros(registros);
                    MessageBox.Show("Datos cargados correctamente" +
                        "\nUltima fecha de modificacion: " + registros.UltimaActualizacion +
                        "\nNumero de registros: " + registros.TotalRegistros, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Funcion para cargar los datos de un archivo JSON al DataGridView
        private void cargarRegistros(BaseDatosJson registros)
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in registros.personas)
            {
                dgvDatos.Rows.Add(persona.nombre, persona.telefono, persona.correo);
            }
        }
    }
}
