namespace gusta1708;

public class Personagem
{
public double Fome;

public double Sede;

public double Brinca;

protected string Nomedafoto;

public Personagem()
{
    Nomedafoto="n-ada";
}

 
public string GetNomedafoto()
{
    return Nomedafoto;
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



