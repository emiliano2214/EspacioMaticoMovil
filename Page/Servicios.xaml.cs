namespace EspacioMaticoMovil.Page;

public partial class Servicios : ContentPage
{
	public Servicios()
	{
		InitializeComponent();
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