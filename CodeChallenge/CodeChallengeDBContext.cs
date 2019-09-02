using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge
{


    public class CodeChallengeDBContext : DbContext
    {
        public CodeChallengeDBContext(DbContextOptions<CodeChallengeDBContext> options)
            : base(options)
        {
        }

        public DbSet<CodeChallengeDataset> CodeChallengeDS { get; set; }
    }
}
