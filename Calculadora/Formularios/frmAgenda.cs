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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show (dGV[0, 1].Value.ToString());

            try
            {
                var BaseDatos = CargarDatos();
                if(sFDBDJason.ShowDialog() == DialogResult.OK)
                {
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
            foreach (DataGridViewRow fila in dGV.Rows)
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

        private void GuardarJson(BaseDatosJson lista)
        {
            var caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,

            };

            string json = JsonConvert.SerializeObject(lista, caracteristicas);
            File.WriteAllText(sFDBDJason.FileName, json);   
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(oFDDBJson.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String json = File.ReadAllText(oFDDBJson.FileName);
                    var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                    CargarRegistros(registros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                }

            }
        }

        private void CargarRegistros(BaseDatosJson registros)
        {
            dGV.Rows.Clear();
            foreach (var persona in registros.Personas)
            {
                dGV.Rows.Add(new object[] { persona.nombre, persona.telefono, persona.correo });
            }        

            MessageBox.Show("Registros: "+registros.TotalRegistros+"\nUltima actualizacion "+registros.UltimaActualizacion.ToString("dd/mm/yyyy") , "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
