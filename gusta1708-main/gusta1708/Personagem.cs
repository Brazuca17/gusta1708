namespace gusta1708;

public class Personagem
{
protected double Fome;

protected double Sede;

protected double Brinca;

 public Personagem()
{
 Fome=1;

 Sede=1;

 Brinca=1;
}

void Fome()
{
    if( F <= 0)
    {
        F = 0;
    }
    else(F >= 1)
    {
        F  = 1;
    }
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

public void SetBrinca(double B)
{
    Brinca=B;
}

public double Getfome()
{
    return Brinca;
}

public void Tirafome()
{ 

double M = F - 0,1;

}






}



