using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace CODE.models
{
    public static class Conversor
    {
        static public string EncodeBinaryToBase64(string strandEncode) // Binário para string
        {
            byte[] strandEncodeAsBytes = Encoding.ASCII.GetBytes(strandEncode);
            string result = System.Convert.ToBase64String(strandEncodeAsBytes);
            return result;
        }

        static public string EncodeBase64ToBinary(string strand) // String para binário
        {
            byte[] strandAsBytes = System.Convert.FromBase64String(strand);
            string result = System.Text.ASCIIEncoding.ASCII.GetString(strandAsBytes);
            return result;
        }

        static public string GeneCheck(string strandEncode, string geneEncoded)
        {
            // Converter os values em string
            string strandString = EncodeBinaryToBase64(strandEncode);
            string geneString = EncodeBinaryToBase64(geneEncoded);
            dynamic result = false;

            if (geneString.StartsWith("CAT"))// Verificar se o geneEncoded começa com "CAT", se não, converter as nucleobase
            {
                foreach (var charsGene in geneString)
                {
                    foreach (var charsStrand in strandEncode)
                    {
                        for (int cont = 0; charsStrand == charsGene; cont++)// verificar se o strandEncode está presente mais de 50% dentro do geneEncoded
                        {
                            if(cont >= (geneString.Length)/2)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }   
            else
            {
                string[] geneStringConvert = geneString.Split(); //Transforma o geneString em um vetor

                foreach (var chars in geneStringConvert)
                {
                    if(chars == "A")
                    {
                        chars.Replace("A", "T");
                    }
                    else if(chars == "T")
                    {
                        chars.Replace("T", "A");
                    }
                    else if(chars == "C")
                    {
                        chars.Replace("C", "G");
                    }
                    else if(chars == "G")
                    {
                        chars.Replace("G", "C");
                    }
                }

                foreach (var charsGeneConvert in geneStringConvert)
                {
                    foreach (var charsStrand in strandEncode)
                    {
                        for (int cont = 0; charsStrand == charsGeneConvert; cont++)// Verificar se o método
                        {
                            if(cont >= (geneString.Length)/2)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}