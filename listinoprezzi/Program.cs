using System;

namespace listinoprezzi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Quanti articoli vuoi inserire?
            // Nome articolo: Tavolo
            // Prezzo: 50
            // Iva: 22


            //obbligazioni
            // array tendente all'infinito
            // calcolo di percentuale iva



            // il programma deve chiedere:
            //quanti articoli inserire
            //il costo degli articoli
            // l'iva che si applica



            string[] articolo = new string[0];
            decimal[] prezzo = new decimal[0];
            double[] ivaApplicata = new double[0];
            double[] ivaCalcolo = new double[0];

            //quanti articoli inserire

            int quantitativoArticoli = 0;

            Console.WriteLine("Quanti articoli vuoi inserire?");
            quantitativoArticoli = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantitativoArticoli; i++)
            {
                Array.Resize(ref articolo, i + 1);
                Array.Resize(ref prezzo, i + 1);
                Array.Resize(ref ivaApplicata, i + 1);
                Array.Resize(ref ivaCalcolo, i + 1);

                Console.WriteLine("\n\nNome Articolo:");
                articolo[i] = Console.ReadLine();

                Console.WriteLine("\nPrezzo: ");
                prezzo[i] = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("\nIva applicata: ");
                ivaApplicata[i] = Convert.ToDouble(Console.ReadLine());

                ivaCalcolo[i] = Convert.ToDouble(prezzo[i]) * ivaApplicata[i] / 100;

            }
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < quantitativoArticoli; i++)
            {
                Console.WriteLine($"\n\nArticolo: {articolo[i]}\nPrezzo: {prezzo[i]}$ Iva{ivaApplicata[i]}% - {ivaCalcolo[i]}$");
            }









        }
    }
}
