using Microsoft.Extensions.DependencyInjection;

namespace gusta1708;

public partial class MainPage : ContentPage
{
	Personagem atual;
     
	George bicho = new George();
	
	Josefina Josefina = new Josefina();

	MeninoNey neymar = new MeninoNey();

	List<FundoImage> Fundo = new List<FundoImage>();
	FundoImage FundoImageAtual



	public MainPage()
	{
		InitializeComponent();

        atual = josefina;

		atualid = 0

		Imgdosbicho.Source = atual.GetNomedafoto();

        ProgressoFome.Progress = atual.GetFome();

		ProgressoSede.Progress = atual.GetSede();

		ProgressoBrinca.Progress = atual.GetBrinca();

		fundo.Add(new FundoImage()
		{
          id = 0,
		  Image.Source = "praia.png",
		});

		fundo.Add(new FundoImage()
		{
          id = 1,
		  Image.Source = "europa.png",
		});

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
		 atual = josefina;
	   }
	}


     void TrocaImageFundo(object sender, eventArgs args)
	 {
		if(atualid = 0)
		var proximofundo = FundoImageAtual.id + 1;

		else if(atualid = 1)
		{
		   var proximofundo = FundoImageAtual.id - 1;
		}
	 }

	
}

