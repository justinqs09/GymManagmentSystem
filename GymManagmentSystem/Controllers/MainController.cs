using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ruta: GymManagementSystem/Controllers/MainController.cs

using GymManagmentSystem.Views;

namespace GymManagementSystem.Controllers
{
    public class MainController
    {
        public void Start()
        {
            var mainView = new MainView();
            mainView.Show();
        }
    }
}
