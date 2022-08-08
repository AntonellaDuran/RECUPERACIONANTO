class Conchile : Decorador
{
  public Conchile ( Ordenbase orden) : base (orden)
  {
    public override double CalcularTotalprecio();
    {
        return base.CalcularTotalprecio()+1.00;
    
  }
}