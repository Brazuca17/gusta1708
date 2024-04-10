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

	int Indicefundoatual = 0;
	


	public MainPage()
	{
		InitializeComponent();

        atual = josefina;

	    Fundo.Add("praia.png");

		Fundo.Add("europa.png");

		imgfundo.Source = Fundo[Indicefundoatual];

		Imgdosbicho.Source = atual.GetNomedafoto();

		AtualizaPersonagem();

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(100);
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
		var comoAtualEstava = atual.Morto;
		atual.SetFome(atual.GetFome() - 0.1);
 		atual.SetSede(atual.GetSede() - 0.1);
        atual.SetBrinca(atual.GetBrinca() - 0.1);
		AtualizaPersonagem();
		if (comoAtualEstava != atual.Morto)
			Imgdosbicho.Source = atual.GetNomedafoto();
	}

//------------------------------------------------------------------------------------------------

    void  TrocaFundo(object sender, EventArgs args)
 {
	if(Indicefundoatual == 1)
	{
		Indicefundoatual = 0;
	}
	else if(Indicefundoatual == 0)
	{
		Indicefundoatual = 1;
	}
	imgfundo.Source = Fundo[Indicefundoatual];
 }

  void GameOver()
  {
	if (atual.SetFome(atual.GetFome() == 0);
 		atual.SetSede(atual.GetSede() == 0);
        atual.SetBrinca(atual.GetBrinca() == 0);)
	 	Application.Current.MainPage = new GamePage();
  	

}

