namespace gusta1708;

public partial class GameOver : ContentPage
{

    public GameOver()
    {
        InitializeComponent();


    }

    void VoltarMenu(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new MainPage();
    } 
}

