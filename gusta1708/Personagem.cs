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

}



