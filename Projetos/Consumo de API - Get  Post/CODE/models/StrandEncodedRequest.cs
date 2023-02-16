using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class StrandEncodedRequest
    {
        public StrandEncodedRequest(string strandEncoded)
        {
            StrandEncoded = strandEncoded;
        }
        public string StrandEncoded { get; set; }
    }
}