namespace EspacioMaticoMovil.Page;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    //Funcion de botones
    private void OnHomeClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Servicios();
    }

    private void OnAcercaDeClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Acerca_de();
    }

    private void OnSalidaClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}