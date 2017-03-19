using System;
using DomainModel;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IIssueContract
    {
        IEnumerable<Issue> GetAllIssues();

        void AddIssue(Issue model);

        void UpdateIssue(Issue model);

        void DeleteIssue(Issue model);

        void DeleteIssue(Guid issueId);

        Issue FindById(Guid issueId);
    }
}
