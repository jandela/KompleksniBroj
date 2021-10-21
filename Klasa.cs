using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBroj
{
    class KompleksniBrojKlasa
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojKlasa(double realni, double imaginarni)
        {
            RealniDio = realni;
            ImaginarniDio = imaginarni;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", RealniDio, ImaginarniDio);
        }
    }
}
