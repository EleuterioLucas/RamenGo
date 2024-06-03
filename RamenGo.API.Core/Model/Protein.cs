using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamenGo.API.Core.Model
{
    public class Protein
    {
        public int id { get; set; }
        public string imageInactive { get; set; }
        public string imageActive { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
    }
}
