using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;

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

        static public bool GeneCheck(string strandEncode, string geneEncoded)
        {
            // Converter os values em string
            string strandString = EncodeBinaryToBase64(strandEncode);
            string geneString = EncodeBinaryToBase64(geneEncoded);

            if (geneString.StartsWith("CAT"))// Verificar se o geneEncoded começa com "CAT", se não, converter as nucleobase
            {
                int activated = (geneString.Length / 2) + 1; // Fazer tratamento para arredandar pracima caso for impar
                bool isActivated = false;

                for (int i = 0; i < geneString.Length ; i++)
                {
                    string fitaMetade = geneString.Substring(i, activated); //Fazer tratamento
                    isActivated = strandEncode.Contains(fitaMetade);
                }

                return isActivated;
            }   
            else
            {
                string[] geneStringConvert = geneString.Split(); //Transforma o geneString em um vetor

                foreach (var chars in geneStringConvert)// Verifica quais as nucleobases da faixa complementar para mudar para faixa test
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

                string geneConvert = string.Join("", geneStringConvert); //Converte o array em string
                int activated = (geneConvert.Length / 2) + 1; // Fazer tratamento para arredandar pracima caso for impar
                bool isActivated = false;

                for (int i = 0; i < geneConvert.Length ; i++)
                {
                    string fitaMetade = geneConvert.Substring(i, activated); //Fazer tratamento
                    isActivated = strandEncode.Contains(fitaMetade);
                }

                return isActivated;
            }
        }
    }
}