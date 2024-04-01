using Microsoft.Extensions.DependencyInjection;

namespace gusta1708;

public partial class MainPage : ContentPage
{
	Personagem atual;
     
	George bicho = new George();
	
	Josefina josefina = new Josefina();

	MeninoNey neymar = new MeninoNey();

	List<String> Fundo = new List<String>();
	


	public MainPage()
	{
		InitializeComponent();

        atual = josefina;

		Imgdosbicho.Source = atual.GetNomedafoto();

        ProgressoFome.Progress = atual.GetFome();

		ProgressoSede.Progress = atual.GetSede();

		ProgressoBrinca.Progress = atual.GetBrinca();

		

	    Fundo.Add("praia.png");

		Fundo.Add("europa.png");
	
imgfundo.Source = Fundo[0];
	}

 //------------------------------------------------------------------------------------------------

     void TrocaPronagem(object sender, EventArgs args)
	{
	   if(atual == josefina)
	   { 
		  atual = neymar;
	   }
	   else if(atual == neymar)
	   { 
		 atual = bicho;
	   }
	   else 
	   {
		 atual = josefina;
	   }
	}

 //------------------------------------------------------------------------------------------------

   
	
//------------------------------------------------------------------------------------------------


 //------------------------------------------------------------------------------------------------
	
}

