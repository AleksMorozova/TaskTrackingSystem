using DomainModel;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IIssueContract
    {
        IEnumerable<Issue> GetAllIssues();
    }
}
