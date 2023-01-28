using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class Jobs
    {
        public Jobs()
        {
            
        }
        public string Id { get; set; }
        public string Type { get; set; }
        //Operations types["DecodeStrand", "EncodeStrand", "CheckGene"]
        public string Strand { get; set; }
        // Strand in String format. Non-null when operation type 'EncodeStrand'
        public string StrandEncoded { get; set; }
        // Strand in the Binary format Base64 encoded. Non-null when operation types 'DecodeStrand' and 'CheckGene'
        public string GeneEncoded { get; set; }
         // A gene segment in the Binary format Base64 encoded. Non-null when operation type 'CheckGene'
        
    }
}