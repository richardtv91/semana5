using semana5.Models;

namespace semana5.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void btnInsertar_Clicked(object sender, EventArgs e)
    {
		statusMessage.Text = "";
		App.personaRepo.AddNewPersona(txtNombre.Text);
		statusMessage.Text = App.personaRepo.statusMesage;
    }
	private void btnListar_Clicked(Object sender, EventArgs e)
	{
		statusMessage.Text = "";
		List<Persona> lista= App.personaRepo.GetAllPersona();
		listaPersona.ItemsSource = lista;
	}
}