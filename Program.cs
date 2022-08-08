internal class Program

namespace RECUPERACION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tacos");
            var tacos = new Tacos ();
            Console.WriteLine($"el precio de los tacos es de" {tacos.CalcularTotalprecio()}");
            var Con chile = new  Conchile (Tacos);
            Console.WriteLine ($"el precio de los tacos con chile es de " {Conchile.CalcularTotalprecio()}");
            var Sin chile = new Sin chile (Tacos);
            Console.WriteLine ($"el precio de los tacos sin chile es de " {Sinchile.CalcularTotalprecio()}");
            var Carne = new Carne ( Tacos);
            Console.WriteLine ($"el precio de los tacos con carne es de " {Carne.CalcularTotalprecio()}");
            var Pollo = new Pollo ( Tacos) ;
            Console.WriteLine ($"el precio de los tacos con pollo es de " {Pollo.CalcularTotalprecio()}");

            
            Console.WriteLine("burritos");
            var burritos = new burritos ();
            Console.WriteLine($"el precio de los burritos es de" {burritos.CalcularTotalprecio()}");
            var Con chile = new  Conchile (burritos);
            Console.WriteLine ($"el precio de los burritos con chile es de " {Conchile.CalcularTotalprecio()}");
            var Sin chile = new Sin chile (burritos);
            Console.WriteLine ($"el precio de los burritos sin chile es de " {Sinchile.CalcularTotalprecio()}");
            var Carne = new Carne ( burritos);
            Console.WriteLine ($"el precio de los burritos con carne es de " {Carne.CalcularTotalprecio()}");
            var Pollo = new Pollo (burritos) ;
            Console.WriteLine ($"el precio de los burritos con pollo es de " {Pollo.CalcularTotalprecio()}");

            Console.WriteLine("Tamales");
            var tamales = new tamales ();
            Console.WriteLine($"el precio de los tamales es de" {tamales.CalcularTotalprecio()}");
            var Con chile = new  Conchile (tamales);
            Console.WriteLine ($"el precio de los tamales con chile es de " {Conchile.CalcularTotalprecio()}");
            var Sin chile = new Sin chile (tamales);
            Console.WriteLine ($"el precio de los tamales sin chile es de " {Sinchile.CalcularTotalprecio()}");
            var Carne = new Carne ( tamales);
            Console.WriteLine ($"el precio de los tamales con carne es de " {Carne.CalcularTotalprecio()}");
            var Pollo = new Pollo ( tamales) ;
            Console.WriteLine ($"el precio de los tamales con pollo es de " {Pollo.CalcularTotalprecio()}");
        }
    }
}
