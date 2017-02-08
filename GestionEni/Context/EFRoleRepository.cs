using GestionEni.Abstract;
using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEni.Context
{
    public class EFRoleRepository:IRoleRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Role> Roles
        {
            get { return context.Roles; }
        }

        public void SaveRole(Role role)
        {
            if (role.IdRole == 0)
            {
                context.Roles.Add(role);
            }
            else
            {
                Role dbEntry = context.Roles.Find(role.IdRole);
                if (dbEntry != null)
                {
                    dbEntry.libelle = role.libelle;
                }
            }
            context.SaveChanges();
        }


        public Role DeleteRole(int roleID)
        {
            Role dbEntry = context.Roles.Find(roleID);
            if (dbEntry != null)
            {
                context.Roles.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
