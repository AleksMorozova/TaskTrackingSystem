using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public enum PermissionType
    {
        None = -1,
        EditUser = 0,
        EditProject = 1,
        EditTask = 2,
        CreateTask = 3,
        CreateProject = 4
    }
}
