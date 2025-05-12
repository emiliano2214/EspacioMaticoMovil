namespace EspacioMaticoMovil.Page;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(UsuarioEntry.Text=="Emiliano" &&  ContraseñaEntry.Text == "1234")
		{
			Application.Current.MainPage = new Servicios();
		}
		else
		{
			DisplayAlert(title: "Error", message: "Credenciales incorrectas", cancel:"OK");
		}
    }
}