using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat
{
    public class CovidData
    {
        public GlobalData Global;
        public List<CountryData> Countries;

        public CovidData()
        {
            Global = new GlobalData();
            Countries = new List<CountryData>();
        }
    }
}
