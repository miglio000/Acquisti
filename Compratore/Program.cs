using System;
using Negozio;
namespace Compratore
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                string nome = GestioneProdotti.Nome();
                double prezzo = GestioneProdotti.Prezzo(i);
                int quantità = GestioneProdotti.Quantità(i);
                double costo_totale = GestioneProdotti.CostoTotale(prezzo, quantità);
                Console.WriteLine($"Il totale del {i + 1}° prodotto chiamato '{nome}' è {costo_totale} euro");
            }
        }
    }
}
