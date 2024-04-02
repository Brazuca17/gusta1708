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

     void TrocaPersonagem(object sender, EventArgs args)
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
  
  void AumentaFome(object sender, EventArgs args)
   {
      atual.SetFome(atual.GetFome() + 0.1);
 
      ProgressoFome.Progress = atual.GetFome();
   }
   
    
//------------------------------------------------------------------------------------------------
  void AumentaSede(object sender, EventArgs args)
  {
      atual.SetSede(atual.GetSede() + 0.1);

      ProgressoSede.Progress = atual.GetSede();
  }
  

 //------------------------------------------------------------------------------------------------
    
    void AumentaBrinca(object sender, EventArgs args)
    {
        atual.SetBrinca(atual.GetBrinca() + 0.1);

        ProgressoBrinca.Progress = atual.GetBrinca();
    }


}

