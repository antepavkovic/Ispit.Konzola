using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Sučelja
{
    public interface ITelefon
    {
        string Model { get; }
        string Poziv(string telefonskiBroj);

    }
}
