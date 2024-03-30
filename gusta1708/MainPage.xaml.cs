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

	 public AumentaFome(object sender, eventArgs args)
	 {
		if(ProgressoFome = 0.0 && >=0.9)
		{
		   ProgressoFome + 0.1;
		}
		else if(ProgressoFome = 1)
		{
			ProgressoFome = 1;
		}
		else 
		{
			ProgressoFome = 0.0;
		}
	 }

	 public AumentaSede(object sender, eventArgs args)
	 {
		if(ProgressoSede = 0.0 && >=0.9)
		{
			ProgressoSede + 0.1;
		}
		else if(ProgressoSede = 1)
		{
			ProgressoSede = 1;
		}
		else
		{
         ProgressoSede = 0;
		}
	 }

	 public AumentaBrinca(object sender, eventArgs args)
	 {
       if(ProgressoBrinca = 0.0 && >= 0.9)
	   {
		 ProgressoBrinca + 0.1;
	   }      
	   else if(ProgressoBrinca = 1)
	   {
		ProgressoBrinca = 1;
	   }
	   else
	   {
		ProgressoBrinca = 0.0;
	   }


	 }

	
}

