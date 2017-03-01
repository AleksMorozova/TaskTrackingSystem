using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository.DBModel
{
    public enum StatusDB
    {
        None = -1,
        Created = 0,
        InProcess = 1,
        OnReview = 2,
        Closed = 3,
        Reopen = 4,
        Resolve = 4
    }
}
