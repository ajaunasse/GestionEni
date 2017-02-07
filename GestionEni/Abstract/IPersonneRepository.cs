using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEni.Abstract
{
    public interface IPersonneRepository
    {
        IQueryable<Personne> Personnes { get; }
        void SavePersonne(Personne personne);
        Personne DeletePersonne(int personneID);
    }
}
