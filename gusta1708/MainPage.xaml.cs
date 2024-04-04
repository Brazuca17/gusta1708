using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

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

	    Fundo.Add("praia.png");

		Fundo.Add("europa.png");
	
		imgfundo.Source = Fundo[0];

		Imgdosbicho.Source = atual.GetNomedafoto();

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(5);
		timer.Tick += (s,e) => 
		PassouTempo(); 
		timer.Start();
	}

 //------------------------------------------------------------------------------------------------

	void AtualizaPersonagem()
	{
        ProgressoFome.Progress = atual.GetFome();
		ProgressoSede.Progress = atual.GetSede();
		ProgressoBrinca.Progress = atual.GetBrinca();
	}

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
	   Imgdosbicho.Source = atual.GetNomedafoto();
	   AtualizaPersonagem();
	}

 //------------------------------------------------------------------------------------------------
  
  	void AumentaFome(object sender, EventArgs args)
   	{
      	atual.SetFome(atual.GetFome() + 0.1);
		AtualizaPersonagem();
   	}
   
    
//------------------------------------------------------------------------------------------------
  	void AumentaSede(object sender, EventArgs args)
  	{
      	atual.SetSede(atual.GetSede() + 0.1);
		AtualizaPersonagem();
  	}
  

 //------------------------------------------------------------------------------------------------
    
    void AumentaBrinca(object sender, EventArgs args)
    {
        atual.SetBrinca(atual.GetBrinca() + 0.1);
		AtualizaPersonagem();
    }

//------------------------------------------------------------------------------------------------

	void PassouTempo()
	{
		atual.SetFome(atual.GetFome() - 0.1);
 		atual.SetSede(atual.GetSede() - 0.1);
        atual.SetSede(atual.GetSede() - 0.1);
		AtualizaPersonagem();
	}

//------------------------------------------------------------------------------------------------

	void TrocaFundo()
	{
      if(imgfundo == 0)
	  {
        imgfundo = 1;
	  }
      else if(imgfundo == 1)
	  {
        imgfundo = 0
	  } 
	}

}

