using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalc
{
    class CurrencyDetails
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public string CAD { get; set; }

        public List<CurrencyDetails> rates { get; set; }
        
    }
}
