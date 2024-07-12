using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Programa
{
    using System;

    namespace URI
    {
        class Program
        {
            static void Main(string[] args)
            {
                CultureInfo CI = CultureInfo.InvariantCulture;

                int cod1, cod2, qte1, qte2;
                double preco1, preco2, total;

                string[] vet = Console.ReadLine().Split(' ');    
                cod1 = int.Parse(vet[0]);   
                qte1 = int.Parse(vet[1]);   
                preco1 = double.Parse(vet[2], CI);

                vet = Console.ReadLine().Split(' ');
                cod2 = int.Parse(vet[0]);
                qte2 = int.Parse(vet[1]);
                preco2 = double.Parse(vet[2], CI);

                total = preco1 * qte1 + preco2 * qte2;

                Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CI ));

            }
        }
    }
}