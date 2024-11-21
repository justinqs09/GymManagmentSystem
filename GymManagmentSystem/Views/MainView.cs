using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ruta: GymManagementSystem/Views/MainView.cs
using System;
using System.Windows.Forms;
using GymManagementSystem.Views;

namespace GymManagmentSystem.Views
{
    public class MainView : Form
    {
        public MainView()
        {
            Text = "Sistema de Gestión de Gimnasio";
            Width = 800;
            Height = 600;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            var btnUsers = new Button
            {
                Text = "Gestionar Usuarios",
                Width = 200,
                Top = 50,
                Left = 50
            };
            Controls.Add(btnUsers);

            btnUsers.Click += (sender, args) =>
            {
                var userView = new UserView();
                userView.ShowDialog();
            };
        }
    }
}
