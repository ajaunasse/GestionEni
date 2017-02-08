using GestionEni.Abstract;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Context
{
    public class EFFormationRepository:IFormationRepository
    {
        private EFDbContext context = new EFDbContext();


        public IQueryable<Formation> Formations
        {
            get { return context.Formations; }
        }

        public void SaveFormation(Formation formation)
        {
            if (formation.IdFormation == 0)
            {
                context.Formations.Add(formation);
            }
            else
            {
                Formation dbEntry = context.Formations.Find(formation.IdFormation);
                if (dbEntry != null)
                {
                    dbEntry.libelle = formation.libelle;
                    dbEntry.description = formation.description;
                    dbEntry.Site1 = formation.Site1;
                    dbEntry.Cursus1 = formation.Cursus1;                    
 
                }
            }
            context.SaveChanges();
        }


        public Formation DeleteFormation(int formationID)
        {
            Formation dbEntry = context.Formations.Find(formationID);
            if (dbEntry != null)
            {
                context.Formations.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}