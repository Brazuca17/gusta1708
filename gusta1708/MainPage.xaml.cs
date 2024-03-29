using Microsoft.Extensions.DependencyInjection;

namespace gusta1708;

public partial class MainPage : ContentPage
{
	 Personagem atual;
     
	George bicho = new George();
	
	Josefina Josefina = new Josefina();

	MeninoNey neymar = new MeninoNey();



	public MainPage()
	{
		InitializeComponent();

        atual = neymar;

		Imgdosbicho.Source = atual.GetNomedafoto();

        ProgressoFome.Progress = atual.GetFome();

		ProgressoSede.Progress = atual.GetSede();

		ProgressoBrinca.Progress = atual.GetBrinca();

	}



	
}

