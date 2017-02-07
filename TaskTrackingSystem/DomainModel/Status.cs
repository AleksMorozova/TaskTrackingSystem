using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public enum Status
    {
        None = -1,
        Created = 0,
        InProcess = 1,
        OnReview = 2,
        Closed = 3,
        Done = 4
    }
}
