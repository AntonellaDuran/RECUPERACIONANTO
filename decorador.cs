using Sistem;
    class Decorador : OrdenBase
    {
        protected OrdenBase orden;
        public Decorador (OrdenBase orden)
        {
            this.orden = orden;
        }
        public virtual double CalcularTotalprecio()
    {
        Console.WriteLine("Calculo del precio del plato desde el decorador");
        return orden.CalcularTotalprecio();

    }

    }   