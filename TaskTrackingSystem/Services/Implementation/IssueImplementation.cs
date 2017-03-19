using System;
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

        public void AddIssue(Issue model)
        {
            var issue = Mapper.Map<Issue, IssueDB>(model);
            Registration.IssueRepository.Create(issue);
        }

        public void UpdateIssue(Issue model)
        {
            var issue = Mapper.Map<Issue, IssueDB>(model);
            Registration.IssueRepository.Update(issue);
        }

        public void DeleteIssue(Issue model)
        {
            var issue = Mapper.Map<Issue, IssueDB>(model);
            Registration.IssueRepository.Remove(issue);
        }

        public void DeleteIssue(Guid issueId)
        {
            Registration.IssueRepository.Remove(issueId);
        }

        public Issue FindById(Guid issueId)
        {
            var issue = Registration.IssueRepository.Read(issueId);
            return Mapper.Map<IssueDB, Issue>(issue);
        }
    }
}
