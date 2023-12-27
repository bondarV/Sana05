using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Currency
    {

        public string Name { get; set; }
        public float ExRate {  get; set; }

        public Currency(string name, float exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
        }   
        public Currency()
        {
            Name = "USD";
            ExRate = 37.55F;
        }
        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
    }
}
