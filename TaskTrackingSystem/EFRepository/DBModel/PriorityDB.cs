using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public enum PriorityDB
    {
        None = -1,
        Critical = 0,
        Major = 1,
        Minor = 2,
        Trivial = 3,
        Blocker = 4
    }
}
