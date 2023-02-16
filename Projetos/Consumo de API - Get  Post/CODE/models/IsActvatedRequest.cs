using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class IsActvatedRequest
    {
        public IsActvatedRequest(string isActvated)
        {
            IsActvated = isActvated;
        }
        public string IsActvated { get; set; }
    }
}