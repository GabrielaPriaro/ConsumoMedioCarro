//Problema "consumo"
//Fazer um programa para ler a distância total (em km) percorrida por um carro, bem como o total de
//combustível gasto por este carro ao percorrer tal distância. Seu programa deve mostrar o consumo
//médio do carro, com três casas decimais. 

using System.Globalization;

namespace ConsumoMedioCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida;
            double combustivelGasto, consumoMedio;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Distancia percorrida: ");
            distanciaPercorrida = int.Parse(Console.ReadLine());

            Console.Write("Combustível gasto: ");
            combustivelGasto = double.Parse(Console.ReadLine(), CI);

            consumoMedio = distanciaPercorrida / combustivelGasto;

            Console.Write($"Consumo medio = {consumoMedio.ToString("F3", CI)}");
        }
    }
}
