class Pollo : Decorador
{
  public Pollo ( Ordenbase orden) : base (orden)
  {
    public override double CalcularTotalprecio();
    {
        return base.CalcularTotalprecio()+0.50;
    
  }
}