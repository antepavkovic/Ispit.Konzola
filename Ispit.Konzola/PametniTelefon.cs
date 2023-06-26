using Ispit.Konzola.Sučelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon, ITelefon
    {
        public string Model { get; private set; }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return "Moguce je ssurfati na tom url-u";
            }
            else
            {
                return "Neispravan url";

            }
        }

        public string Poziv(string telefonskiBroj)
        {
            if (ProvjeriAkoJeValidanUrl(telefonskiBroj))
            {
                return "Moguce je zvati taj telefonski broj";
            }
            else
            {
                return "Neispravan telefonski broj";

            }


        }
        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            string[] urll = new[] { url };
            for (int i = 0; i < urll.Length; i++)
            {
                if (Regex.IsMatch(urll[i], @"^\d+$"))
                {
                    return false;
                }

            }
            return true;


        }
        public bool ProvjeriAkoJeValidanBroj(string telefonskibroj)
        {
            string[] tb = new[] { telefonskibroj };
            for (int i = 0; i < tb.Length; i++)
            {
                if (!Regex.IsMatch(tb[i], @"^\d+$"))
                {
                    return false;
                }

            }
            return true;

        }
        public PametniTelefon(string Model)
        {
            this.Model = Model;

        }


    }
}
