using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Abstract
{
    public interface IFormationRepository
    {
        IQueryable<Formation> Formations { get; }
        void SaveFormation(Formation formation);        
        Formation DeleteFormation(int formationID);
    }
}