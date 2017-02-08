using GestionEni.Abstract;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEni.Context
{
    public class EFPersonneRepository:IPersonneRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Personne> Personnes
        {
            get { return context.Personnes; }
        }


        public void SavePersonne(Personne personne)
        {
            if (personne.IdPersonne == 0)
            {
                context.Personnes.Add(personne);
            }
            else
            {
                Personne dbEntry = context.Personnes.Find(personne.IdPersonne);
                if (dbEntry != null)
                {
                    dbEntry.firstname = personne.firstname;
                    dbEntry.lastname = personne.lastname;
                    dbEntry.username = personne.username;
                    dbEntry.password = personne.password;
                    dbEntry.email = personne.email;
                    dbEntry.Role = personne.Role;
                    dbEntry.Role1 = personne.Role1;
                }
            }
            context.SaveChanges();
        }


        public Personne DeletePersonne(int personneID)
        {
            Personne dbEntry = context.Personnes.Find(personneID);
            if (dbEntry != null)
            {
                context.Personnes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
