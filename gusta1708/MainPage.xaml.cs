using Microsoft.Extensions.DependencyInjection;

namespace gusta1708;

public partial class MainPage : ContentPage
{
	 Personagem atual;
     
	George bicho = new George();
	

	public MainPage()
	{
		InitializeComponent();

        atual = bicho;

		Imgdosbicho.Source = atual.GetNomedafoto();

        ProgressoFome.Progress = atual.GetFome();

		ProgressoSede.Progress = atual.GetSede();

		ProgressoBrinca.Progress = atual.GetBrinca();

	}



	
}

