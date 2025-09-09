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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show ("Nombre: " + dgvDatos[0, 0].Value.ToString());

            try
            {
                var BaseDatos = CargarDatos();
                if (sfvBDJson.ShowDialog() == DialogResult.OK)
                {
                    GuardarJson(BaseDatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            foreach (DataGridViewRow fila in dgvDatos.Rows)
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdDBJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofdDBJson.FileName);
                    var registros =
                        JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    MessageBox.Show("Numero de registros: " + registros.TotalRegistros
                        + "\nUltima Actualizacion: "
                        + registros.UltimaActualizacion.ToString("dd/MM/yyyy"),
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CargarRegistros(registros);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarRegistros(BaseDatosJson registros)
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in registros.Personas)
            {
                dgvDatos.Rows.Add(new object[] { persona.nombre, persona.telefono, persona.correo });
            }
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {

        }
    }
}
