using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Context
{
    public class EFCursusRepository
    {
      private EFDbContext context = new EFDbContext();


        public IQueryable<Cursus> Cursus
        {
            get { return context.Cursus; }
        }

        public void SaveCursus(Cursus cursus)
        {
            if (cursus.IdCursus == 0)
            {
                context.Cursus.Add(cursus);
            }
            else
            {
                Cursus dbEntry = context.Cursus.Find(cursus.IdCursus);
                if (dbEntry != null)
                {
                    dbEntry.libelle = cursus.libelle;
                    dbEntry.description = cursus.description;
                }
            }
            context.SaveChanges();
        }


        public Cursus DeleteCursus(int cursusID)
        {
            Cursus dbEntry = context.Cursus.Find(cursusID);
            if (dbEntry != null)
            {
                context.Cursus.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}