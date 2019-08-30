using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge
{
    public class CodeChallengeDBContext : DbContext
    {
        public CodeChallengeDBContext(DbContextOptions<CodeChallengeDBContext> context):base(context)
        {

        }
    }

    //public DbSet<Workshop> Workshops { get; set; }
}
