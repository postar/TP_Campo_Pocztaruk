using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRole : IEntity
    {
        string Name { get; set; }
        void AddRole(IRole role);
        void RemoveRole(IRole role);
        IList<IRole> GetRoles();
    }
}
