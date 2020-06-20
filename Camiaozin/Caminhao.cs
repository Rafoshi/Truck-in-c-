using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMLib.Extensions;

namespace Camiaozin
{
    public class Caminhao
    {
        string combustivel = "gasolina";
        double velocidade = 0;

        public void TrocarCombustivel()
        {
            Console.WriteLine("Insira o nome do combustível:");
            string input = Console.ReadLine();
            input = input.RemoveDiacritics();

            string _combustivel = input.ToLower();
            if (_combustivel=="diesel"||_combustivel=="gas"||_combustivel=="gasolina")
            {
                if (_combustivel == "gas")
                {
                    combustivel = _combustivel;
                }
                if (_combustivel == "diesel")
                {
                    combustivel = _combustivel;
                }
                if (_combustivel == "gasolina")
                {
                    combustivel = _combustivel;
                }
            }
            else
            {
                Console.WriteLine("Escolha entre Gas Diesel e Gasolina apenas :P\n");
                TrocarCombustivel();
            }
        }

        public void TrocarVelocidade()
        {
            try
            {
                Console.Write("Digite um valor de 0 a 150 para sua nova velocidade:");
                double _velocidade = double.Parse(Console.ReadLine());
                if (_velocidade <= 150 && _velocidade >= 0)
                {
                    velocidade = _velocidade;
                }
                else
                {
                    Console.WriteLine("Digite um valor entre 0 e 150");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n"+e.Message);
                TrocarVelocidade();
            }
        }

        public void MostrarStatus()
        {
            Console.WriteLine($"\nSeu combustível atual é: { combustivel}");
            Console.WriteLine($"Sua velocidade atual é: { velocidade }\n");
        }
    }
}