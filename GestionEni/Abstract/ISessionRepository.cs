using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Abstract
{
    public interface ISessionRepository
    {
        IQueryable<Session> Sessions { get; }
        void SaveSession(Session session);
        Session DeleteSession(int sessionID);
    }
}