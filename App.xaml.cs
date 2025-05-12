using EspacioMaticoMovil.Page;

namespace EspacioMaticoMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
