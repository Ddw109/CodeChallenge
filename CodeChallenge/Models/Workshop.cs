using System;

namespace CodeChallenge.Models
{
    public enum CurrentStatus
    {
        NotApplicable,
        Created,
        InProgress,
        Complete,
        Cancelled

    }

    public class CodeChallengeDataset
    {
       public Guid Id { get; set; }
       public string BuildingCode { get; set; }
       public string Description { get; set; }

       public CurrentStatus? CurrentStatus { get; set; }

       //public enum currentStatus { get; set; }
       public string CreatedBy { get; set; }
       public DateTime CreatedDate { get; set; }
       public string LastModifiedBy { get; set; }
       public DateTime LastUpdatedBy { get; set; }

    }
}