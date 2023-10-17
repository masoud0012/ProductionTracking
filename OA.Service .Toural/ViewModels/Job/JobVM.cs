using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.ViewModels.Job
{
    public class JobVM:BaseVM
    {
        public int numberRows { get; set; }
        public JobDto jobDto { get; set; }
        public List<JobDto> jobDtos { get; set; }
    }
}
