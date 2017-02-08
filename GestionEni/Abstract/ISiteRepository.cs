using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Abstract
{
    public interface ISiteRepository
    {
        IQueryable<Site> Sites { get; }
        void SaveSite(Site site);
        Site DeleteSite(int siteID);

    }
}