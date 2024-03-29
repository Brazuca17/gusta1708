using Microsoft.Extensions.DependencyInjection;

namespace gusta1708;

public partial class MainPage : ContentPage
{
	 Personagem atual;
     
	George bicho = new George();
	
	Josefina Josefina = new Josefina();

	MeninoNey neymar = new MeninoNey();

	Praia praia = new Praia();

	Europa europa = new Europa();




	public MainPage()
	{
		InitializeComponent();

        atual = josefina;

		atualfundo = Praia

		Imagedofundo.Source = atualfundo.GetNomedaFotoFundo();

		Imgdosbicho.Source = atual.GetNomedafoto();

        ProgressoFome.Progress = atual.GetFome();

		ProgressoSede.Progress = atual.GetSede();

		ProgressoBrinca.Progress = atual.GetBrinca();

	}

     void TrocaPronagem(object sender, eventArgs args)
	{
	   if(atual = josefina)
	   { 
		  atual = neymar;
	   }
	   else if(atual = neymar)
	   { 
		 atual = bicho;
	   }
	   else 
	   {
		 atual = josefina
	   }
	}

	 void TrocaFundo(object sender, eventArgs args)
	 {
		if(atualfundo = praia)
		{
		   atualfundo = europa
		}
		else if(atualfundo = europa)
        {
			atualfundo = praia
		}
	 }


	
}

