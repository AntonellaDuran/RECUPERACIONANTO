class Sinchile : Decorador
{
  public Sinchile ( Ordenbase orden) : base (orden)
  {
    public override double CalcularTotalprecio();
    {
        return base.CalcularTotalprecio()+0.60;
    
  }
}