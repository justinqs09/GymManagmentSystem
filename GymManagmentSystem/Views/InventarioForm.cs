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
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configuración del formulario
            this.Text = "Gestión de Inventario";
            this.ClientSize = new System.Drawing.Size(600, 400);

            // Controles
            Label lblTitulo = new Label
            {
                Text = "Inventario de Máquinas",
                Location = new System.Drawing.Point(20, 20),
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold)
            };
            ListBox lstInventario = new ListBox { Location = new System.Drawing.Point(20, 60), Width = 540, Height = 250 };

            // Lista de máquinas con fechas de vida útil (puedes conectarlo con una base de datos o lista más avanzada)
            List<(string maquina, DateTime fechaFinVida)> inventario = new List<(string, DateTime)>
            {
                ("Cinta de correr", DateTime.Now.AddMonths(2)),
                ("Bicicleta estática", DateTime.Now.AddMonths(4)),
                ("Máquina de remo", DateTime.Now.AddMonths(1)),
                ("Elíptica", DateTime.Now.AddMonths(6)),
                ("Pesas libres", DateTime.Now.AddMonths(12)),
                ("Máquina de abdominales", DateTime.Now.AddMonths(3))
            };
            Button btnReportes = new Button
            {
                Text = "Ver Reportes",
                Location = new System.Drawing.Point(150, 330),
                Width = 120
            };
            this.Controls.Add(btnReportes);

            btnReportes.Click += (sender, e) =>
            {
                ReportesForm reportesForm = new ReportesForm();
                reportesForm.ShowDialog();
            };


            // Agregar máquinas al inventario
            foreach (var item in inventario)
            {
                string status = item.fechaFinVida <= DateTime.Now.AddMonths(3)
                    ? "(¡Revisión Necesaria!)"
                    : "(En buen estado)";
                lstInventario.Items.Add($"{item.maquina} - Vida útil hasta: {item.fechaFinVida.ToShortDateString()} {status}");
            }

            // Botón para cerrar sesión
            Button btnCerrarSesion = new Button { Text = "Cerrar Sesión", Location = new System.Drawing.Point(20, 330), Width = 120 };

            // Agregar controles al formulario
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lstInventario);
            this.Controls.Add(btnCerrarSesion);

            // Evento del botón cerrar sesión
            btnCerrarSesion.Click += (sender, e) =>
            {
                this.Close(); // Cierra el formulario actual y regresa al login
            };
        }
    }
}
