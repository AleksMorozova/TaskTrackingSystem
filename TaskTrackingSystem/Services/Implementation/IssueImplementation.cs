using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using EFRepository.DBModel;
using AutoMapper;

namespace Services.Implementation
{
    class IssueImplementation : IIssueContract
    {
        public List<Issue> GetAllIssues()
        {
            List<Issue> resultIssuesList = new List<Issue>();
            Registration.IssueRepository.ReadAll().ToList()
                .ForEach(issue => resultIssuesList.Add(Mapper.Map<IssueDB, Issue>(issue)));
            return resultIssuesList;
        }
    }
}
