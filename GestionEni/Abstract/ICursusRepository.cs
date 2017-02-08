using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionEni.Abstract
{
    public interface ICursusRepository
    {
        IQueryable<Cursus> Cursus { get; }
        void SaveCursus(Cursus cursus);
        Cursus DeleteCursus(int cursusID);
    }
}