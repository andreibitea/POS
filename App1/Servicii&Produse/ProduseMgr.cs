using Entitati;
using System.Xml;

namespace App1
{
    public class ProduseMgr : ProdusAbstractMgr
    {
        public Produs userInputData(int id)
        {
            string? nume;
            string? codIntern;
            string? producator;
            string? categorie;
            int pret;

            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();
            Console.Write("Producator:");
            producator = Console.ReadLine();
            Console.WriteLine("Categoria: ");
            categorie = Console.ReadLine();

            Console.WriteLine("Pret: ");
            pret = int.Parse(Console.ReadLine() ?? string.Empty);
            return new Produs(id, nume, codIntern, producator, categorie, pret);
        }
    }
}
