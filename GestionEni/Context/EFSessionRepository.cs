using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Context
{
    public class EFSessionRepository
    {
        private EFDbContext context = new EFDbContext();


        public IQueryable<Session> Session
        {
            get { return context.Sessions; }
        }

        public void SaveSession(Session session)
        {
            if (session.IdSession == 0)
            {
                context.Sessions.Add(session);
            }
            else
            {
                Session dbEntry = context.Sessions.Find(session.IdSession);
                if (dbEntry != null)
                {
                    dbEntry.dateDebut = session.dateDebut;
                    dbEntry.dateFin = session.dateFin;
                    dbEntry.Formation1 = session.Formation1;
                    dbEntry.formateur = session.formateur;
                    dbEntry.Stagiaires1 = session.Stagiaires1;
                }
            }
            context.SaveChanges();
        }


        public Session DeleteSession(int sessionID)
        {
            Session dbEntry = context.Sessions.Find(sessionID);
            if (dbEntry != null)
            {
                context.Sessions.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}