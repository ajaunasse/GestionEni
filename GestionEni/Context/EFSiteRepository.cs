using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Context
{
    public class EFSiteRepository
    {
              private EFDbContext context = new EFDbContext();


        public IQueryable<Site> Sites
        {
            get { return context.Sites; }
        }

        public void SaveSite(Site site)
        {
            if (site.IdSite == 0)
            {
                context.Sites.Add(site);
            }
            else
            {
                Site dbEntry = context.Sites.Find(site.IdSite);
                if (dbEntry != null)
                {
                    dbEntry.ville = site.ville;
                    dbEntry.adresse = site.adresse;
                    dbEntry.codepostal = site.codepostal;
                    dbEntry.telephone = site.telephone;
                    dbEntry.fax = site.fax;
                }
            }
            context.SaveChanges();
        }


        public Site DeleteSite(int siteID)
        {
            Site dbEntry = context.Sites.Find(siteID);
            if (dbEntry != null)
            {
                context.Sites.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
 }