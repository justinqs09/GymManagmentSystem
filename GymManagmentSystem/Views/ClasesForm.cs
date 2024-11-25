using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GymManagementSystem
{
    public partial class ClasesForm : Form
    {
        public ClasesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configuración del formulario
            this.Text = "Gestión de Clases";
            this.ClientSize = new System.Drawing.Size(600, 400);

            // Controles
            Label lblTitulo = new Label { Text = "Clases Disponibles", Location = new System.Drawing.Point(20, 20), Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold) };
            ListBox lstClases = new ListBox { Location = new System.Drawing.Point(20, 60), Width = 540, Height = 200 };
            Button btnReservar = new Button { Text = "Reservar", Location = new System.Drawing.Point(20, 280), Width = 100 };

            // Lista de clases (puedes adaptarla a una fuente de datos más avanzada)
            List<string> clases = new List<string>
            {
                "Zumba - Lunes 10:00 AM - Entrenador: Ana (Cupo: 15)",
                "CardioDance - Martes 6:00 PM - Entrenador: Luis (Cupo: 10)",
                "Funcionales - Miércoles 8:00 AM - Entrenador: Carlos (Cupo: 20)"
            };

            // Agregar clases a la lista
            foreach (var clase in clases)
            {
                lstClases.Items.Add(clase);
            }

            // Agregar controles al formulario
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lstClases);
            this.Controls.Add(btnReservar);

            // Evento para reservar clase
            btnReservar.Click += (sender, e) =>
            {
                if (lstClases.SelectedItem != null)
                {
                    MessageBox.Show($"Reserva exitosa para la clase: {lstClases.SelectedItem.ToString()}", "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una clase para reservar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
    }
}
