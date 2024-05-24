using App1.Criteriu;
using Entitati;

namespace App1.Filtrare
{
    internal interface IFiltrare
    {
        List<ProdusAbstract> Filtrare(List<ProdusAbstract> elem, ICriteriu criteriu);
    }
}
