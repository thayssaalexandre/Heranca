using Herança.Exer1;
using Herança.Exer2;
using Heranca.Exer2;
using Herança.Exer3;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cachorro c = new Cachorro();

            //c.Latir();
            //c.Nome = "Laila";
            //c.Comer();

            //Gato g = new Gato();
            //g.Miar();
            //c.Nome = "Sharpay Evans";
            //c.Comer();
            /////////////////////////////

            //Funcionario Fu = new Funcionario("Mariana Santos");
            //Funcionario Ge = new Gerente("Thayssa Alexandre", 0);
            //Funcionario De = new Desenvolvedor("Ana Clara Alves", 0);
           
            //Fu.Salario = 3500;
            //Ge.Salario = 50000;
            //De.Salario = 5500;
            
            //Console.WriteLine(Fu.CalcularBonusAnual());
            //Console.WriteLine(Ge.CalcularBonusAnual());
            //Console.WriteLine(De.CalcularBonusAnual());

            /////////////////////////////////////////////////////////
            
            Retangulo R = new Retangulo();
            Circulo C = new Circulo();

            C.Raio = 3;
            Console.WriteLine(C.CalcularArea());

            R.Largura = 10;
            R.Altura = 25;
            Console.WriteLine(R.CalcularArea());


        }
    }
}
