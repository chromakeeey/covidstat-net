using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidStat
{
    public class GlobalData
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }

        public GlobalData()
        {
            NewConfirmed = 0;
            TotalConfirmed = 0;
            NewDeaths = 0;
            TotalDeaths = 0;
            NewRecovered = 0;
            TotalRecovered = 0;
        }
    }
}
