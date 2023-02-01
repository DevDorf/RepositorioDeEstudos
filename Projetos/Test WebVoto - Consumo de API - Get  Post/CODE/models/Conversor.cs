using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CODE.models
{
    public static class Conversor
    {
        static public string EncodeBinaryToBase64(string strand) // Binário para string
        {
            byte[] strandAsBytes = Encoding.ASCII.GetBytes(strand);
            string result = System.Convert.ToBase64String(strandAsBytes);
            return result;
        }

        static public string EncodeBase64ToBinary(string strandEncoded) // String para binário
        {
            byte[] strandEncodedAsBytes = System.Convert.FromBase64String(strandEncoded);
            string result = System.Text.ASCIIEncoding.ASCII.GetString(strandEncodedAsBytes);
            return result;
        }
    }
}