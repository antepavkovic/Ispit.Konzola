using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class Program

    {
       
        
        static void Main(string[] args)
        {
            PametniTelefon pt = new PametniTelefon("nokia");
            Console.WriteLine(pt.Surfanje("www.google.hr"));
            Console.WriteLine(pt.Poziv("0998899889"));
            Console.ReadLine();
            
        }
    }
}
