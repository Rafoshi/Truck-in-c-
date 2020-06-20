using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camiaozin
{
    class Program
    {
        static void Main(string[] args)
        {
            Caminhao caminhazin = new Caminhao();
            caminhazin.MostrarStatus();

            caminhazin.TrocarCombustivel();
            caminhazin.MostrarStatus();

            caminhazin.TrocarVelocidade();
            caminhazin.MostrarStatus();

            Console.ReadKey();
        }
    }
}
