using GestionEni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEni.Abstract
{
    public interface IRoleRepository
    {
        IQueryable<Role> Roles { get; }
        void SaveRole(Role role);
        Role DeleteRole(int roleID);
    }
}
