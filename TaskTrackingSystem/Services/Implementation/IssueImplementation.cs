using System;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;
using DomainModel;
using AutoMapper;

namespace Services.Implementation
{
    public class IssueImplementation : IIssueContract
    {
        public IEnumerable<Issue> GetAllIssues()
        {
            return Registration.IssueRepository.ReadAll().ToList();
        }

        public void AddIssue(Issue issue)
        {
            Registration.IssueRepository.Create(issue);
        }

        public void UpdateIssue(Issue issue)
        {
            Registration.IssueRepository.Update(issue);
        }

        public void DeleteIssue(Issue issue)
        {
            Registration.IssueRepository.Remove(issue);
        }

        public void DeleteIssue(Guid issueId)
        {
            Registration.IssueRepository.Remove(issueId);
        }

        public Issue FindById(Guid issueId)
        {
            return Registration.IssueRepository.Read(issueId);
        }
    }
}
