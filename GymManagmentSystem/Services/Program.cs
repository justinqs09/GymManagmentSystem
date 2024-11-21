using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ruta: GymManagementSystem/Program.cs
using System;
using GymManagementSystem.Controllers;

namespace GymManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa el sistema a través del controlador principal
            var mainController = new MainController();
            mainController.Start();
        }
    }
}
