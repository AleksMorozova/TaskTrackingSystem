using Services.Contracts;
using System.Collections.Generic;
using System.Linq;
using DomainModel;
using EFRepository.DBModel;
using AutoMapper;

namespace Services.Implementation
{
    public class IssueImplementation : IIssueContract
    {
        public IEnumerable<Issue> GetAllIssues()
        {
            return Registration.IssueRepository.ReadAll().ToList().Select(Mapper.Map<IssueDB, Issue>);
        }
    }
}
