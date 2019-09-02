using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;

namespace CodeChallenge
{
    public class DataInjector
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeChallengeDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<CodeChallengeDBContext>>()))
            {
                if (context.CodeChallengeDS.Any())
                {
                    return;
                }

                context.CodeChallengeDS.AddRange(
                    new CodeChallengeDataset
                    {
                        //Id = "727b376b-79ae-498e-9cff-a9f51b848ea4",
                        BuildingCode = "COH",
                        Description = "Please turn up the AC in suite 1200D. It is too hot here.",
                        CurrentStatus = CurrentStatus.Created,
                        CreatedBy = "Nik Patel",
                        //CreatedDate =("2019-08-01T14:25:43.511Z"),
                        LastModifiedBy = "Jane Doe",
                        //LastUpdatedBy = "2019-08-01T15:01:23.511Z"

                    });
            }
        }


    }
}
