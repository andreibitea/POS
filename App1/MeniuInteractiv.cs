using Entitati;
using System;

namespace App1
{
    internal class MeniuInteractiv
    {
        ProduseMgr prod = new ProduseMgr();
        ServiciiMgr serv = new ServiciiMgr();
        Pachet pch = new Pachet();
        PachetMgr pchMgr = new PachetMgr();
        int noOfPcK;

        public void Menu()
        {
            int op;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                optiuniMeniu();
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("Alege o optiune: ");
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Optiune invalida. Te rog sa incerci din nou.");
                    continue;
                }

                actiuniMeniu(op);
            } while (op != 0);
        }

        private void optiuniMeniu()
        {
            Console.WriteLine("\n0. Inchide programul");
            Console.WriteLine("1. Actualizeaza setarile");
            Console.WriteLine("2. Adauga pachete de la tastatura");
            Console.WriteLine("3. Afiseaza pachetele");
            Console.WriteLine("4. Incarca pachetele din xml");
            Console.WriteLine("5. Filtrare dupa categorie");
            Console.WriteLine("6. Filtrare dupa pret");
            Console.WriteLine("7. Serializeaza pachete");
            Console.WriteLine("8. Deserializeaza pachete");
        }

        private void actiuniMeniu(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Program inchis.");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Nr. de produse si servicii:");
                    pch.setTheNumberOfProducts();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Introdu Pachete");
                    Console.Write("Cate pachete introduci: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        pchMgr.readPachet(number);
                        pchMgr.Sortare();
                    }
                    else
                    {
                        Console.WriteLine("Numar invalid.");
                    }
                    break;
                case 3:
                    Console.Clear();
                    pchMgr.afis();
                    break;
                case 4:
                    Console.Clear();
                    pchMgr.InitListafromXML();
                    pchMgr.Sortare();
                    Console.WriteLine("Incarcat cu succes!");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Categoria dorita: ");
                    pchMgr.FiltrareDupaCategorieProd();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Filtrul de pret: ");
                    pchMgr.FiltrareDupaPretProd();
                    break;
                case 7:
                    Console.Clear();
                    Console.Write("Cate pachete doriti sa serializati: ");
                    if (int.TryParse(Console.ReadLine(), out noOfPcK))
                    {
                        pchMgr.dataSerialization(noOfPcK);
                    }
                    else
                    {
                        Console.WriteLine("Numar invalid.");
                    }
                    break;
                case 8:
                    Console.Clear();
                    pchMgr.dataDeserialization();
                    Console.WriteLine("Deserializarea a avut loc cu succes");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Optiune invalida.");
                    break;
            }
        }
    }
}
