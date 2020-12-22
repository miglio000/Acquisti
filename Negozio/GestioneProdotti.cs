using System;

namespace Negozio
{
    public class GestioneProdotti
    {
        public static string Nome()
        {
            Console.Write("Inserisci nome prodotto: ");
            string nome = Console.ReadLine();
            return nome;
        }
        public static double Prezzo(int c)
        {
            double prezzo;
            do
            {
                Console.WriteLine($"Inserisci costo {c + 1}° prodotto: ");
                prezzo = Convert.ToDouble(Console.ReadLine());
            } while (prezzo <= 0);
            return prezzo;
        }
        public static int Quantità(int c)
        {
            int quantità;
            Console.WriteLine($"Inserisci quante volte vuoi acquistare il {c + 1}° prodotto: ");
            quantità = Convert.ToInt32(Console.ReadLine());
            return quantità;
        }
        public static double CostoTotale(double prezzo, int quantità)
        {
            double costo_totale = prezzo * quantità;
            return costo_totale;
        }
    }
}
