namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();

            c.Latir();
            c.Nome = "Laila";
            c.Comer();

            Gato g = new Gato();
            g.Miar();
            c.Nome = "Sharpay Evans";
            c.Comer();
        }
    }
}
