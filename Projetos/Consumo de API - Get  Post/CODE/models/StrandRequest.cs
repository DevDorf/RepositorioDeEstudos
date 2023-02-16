using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class StrandRequest
    {
        public StrandRequest(string strand)
        {
            Strand = strand;
        }

        public string Strand { get; set; }
    }
}