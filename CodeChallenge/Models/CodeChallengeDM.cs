using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Models
{
    public class CodeChallengeDM
    {
        public int id { get; set; }
        public string buildingCode { get; set; }
        public string description { get; set; }
        //public enum currentStatus { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string lastModifiedBy { get; set; }
        public DateTime lastUpdatedBy { get; set; }
    }

    public enum currentStatus
    {

    }
}
