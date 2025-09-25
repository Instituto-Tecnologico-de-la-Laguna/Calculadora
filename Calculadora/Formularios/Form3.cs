using Calculadora.Utilidades;
using Newtonsoft.Json;
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
    public partial class frmTelefono : Form
    {
        public frmTelefono()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nombre :" + dgvDatos[0, 0].Value.ToString());
            try
            {
                var baseDatos = cargarDatos();
                if(sfdJson.ShowDialog() == DialogResult.OK)
                {
                    guardarJson(baseDatos);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private BaseDatosJson cargarDatos()
        {
            var registros = new BaseDatosJson();
            foreach(DataGridViewRow fila in dgvDatos.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[1].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[2].Value?.ToString() ?? "";
                }
                registros.Personas.Add(persona);
            }
            registros.TotalRegistros = registros.Personas.Count;
            return registros;
        }

        private void guardarJson(BaseDatosJson lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore
            };

            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(sfdJson.FileName, json);
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(ofdDBJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofdDBJson.FileName);
                    var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    cargarJson(registros);
                    MessageBox.Show("Registros cargados: " + registros.TotalRegistros + "\n" + "Ultima actualizacion : " + registros.ultimaActualizacion, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cargarJson(BaseDatosJson registros)
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in registros.Personas)
            {
                dgvDatos.Rows.Add(new object[] { persona.nombre, persona.telefono, persona.correo });
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
