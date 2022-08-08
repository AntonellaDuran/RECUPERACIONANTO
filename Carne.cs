class Carne : Decorador
{
  public Carne ( Ordenbase orden) : base (orden)
  {
    public override double CalcularTotalprecio();
    {
        return base.CalcularTotalprecio()+0.45;
    
  }
}