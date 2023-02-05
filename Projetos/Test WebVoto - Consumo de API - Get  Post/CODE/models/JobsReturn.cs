using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class JobsReturn
    {
        public JobsReturn()
        {
            
        }
        public JobsReturn(string strand, string strandEncoded, bool isActvated)
        {
            Strand = strand;
            StrandEncoded = strandEncoded;
            IsActvated = isActvated;
        }

        public string Strand { get; set; }
        public string StrandEncoded { get; set; }
        public bool IsActvated { get; set; }
    }
}