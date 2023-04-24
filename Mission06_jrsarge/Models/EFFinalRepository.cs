using Mission06_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_jrsarge.Models
{
    interface EFFinalRepository : IFinalRepository
    {
        private FinalContext context { get; set; }

        public EFFinalRepository(FinalContext temp)
        {
            context = temp;
        }
        public IQueryable<MovieSubmission> Entertainers => context.Projects
    }
}
