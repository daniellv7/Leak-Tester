using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSR
{
    public class Step
    {
        public int Socket { get; internal set; }
        public int StepNumber { get; set; }
        public string StepName { get; set; }
        public string Status { get; set; }

    }
}
