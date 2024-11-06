using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser2
{
    public class Produkt : IIdentifable
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public decimal Pris { get; set; }
    }
}
