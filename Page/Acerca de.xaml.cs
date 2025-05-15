namespace EspacioMaticoMovil.Page;

public partial class Acerca_de : ContentPage
{
	public Acerca_de()
	{
		InitializeComponent();
	}
    private void OnHomeClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Servicios();
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Menu();
    }

    private void OnSalidaClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }

}