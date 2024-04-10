namespace gusta1708;

public class Personagem
{
public double Fome;

public double Sede;

public double Brinca;

protected string Nomedafotovivo;

protected string Nomedafotomorto;

public bool Morto;


//------------------------------------------------------------------------------------------------

public string GetNomedafoto()
{   
  if(Morto)
     return NomedafotoMorto;
  else
    return Nomedafoto;
}

//------------------------------------------------------------------------------------------------

public string GetImageMorto()
{
  return Morto;
}

//------------------------------------------------------------------------------------------------

public void SetFome(double F)
{             
  Fome=F;
  if(Fome <= 0)
  {
    Morto=true;
  }
}

public double GetFome()
{
    return Fome;
}

//------------------------------------------------------------------------------------------------
 
public void SetSede(double S)
{
    Sede=S;
    if(Sede <= 0 )
    {
      Morto=true;
    }
}

public double GetSede()
{
    return Sede;
}

//------------------------------------------------------------------------------------------------

public double GetBrinca()
  {
    return Brinca;
  }

public void SetBrinca(double B)
{
    Brinca=B;
    if(Brinca <= 0)
    {
      Morto=true;
    }
}

<<<<<<< HEAD
//------------------------------------------------------------------------------------------------
=======
public string GetNomedafoto()
{
  if(Morto)
  return Nomedafotomorto;
  else 
  return Nomedafotovivo;
}
>>>>>>> 278e7daf182ad8201cd53802b2d31871c0ac8e21

<<<<<<< HEAD
=======
 
>>>>>>> 278e7daf182ad8201cd53802b2d31871c0ac8e21
}
}







