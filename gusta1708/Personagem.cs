namespace gusta1708;

public class Personagem
{
public double Fome;

public double Sede;

public double Brinca;

protected string Nomedafoto;

public bool Morto;

public string NomedafotoMorto;



public string GetNomedafoto()
{   
  if(Morto)
     return NomedafotoMorto;
  else
    return Nomedafoto;
}

public string GetImageMrto()
{
    return ImageMorto;
}

public void SetFome(double F)
{
  Fome=F;
}

public double GetFome()
{
    return Fome;
}
 
public void SetSede(double S)
{
    Sede=S;
}

public double GetSede()
{
    return Sede;
}

public double GetBrinca()
  {
    return Brinca;
  }

public void SetBrinca(double B)
{
    Brinca=B;
}


 


}



