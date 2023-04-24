using Mission06_jrsarge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_jrsarge.Models
{
    public interface IFinalRepository
    {
        IQueryable<MovieSubmission> Entertainers { get; set; }
    }
}
