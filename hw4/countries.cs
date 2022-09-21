using System;

namespace Azerbaijan
{
    class Baku
    {
        private int BakuPopulation;
        public int bakupopulation
        {
            get { return BakuPopulation; }
            set { BakuPopulation = value; }
        }
        public Baku(int population)
        {
            BakuPopulation = population;
        }
    }
}

namespace USA
{
    class Washington
    {
        private int WashingtonPopulation;
        public int washingtonpopulation
        {
            get { return WashingtonPopulation; }
            set { WashingtonPopulation = value; }
        }
        public Washington(int population) 
        { 
            WashingtonPopulation = population; 
        }
    }
}

namespace Russia
{
    class Moscow
    {
        private int MoscowPopulation;
        public int moscowpopulation
        {
            get { return MoscowPopulation; }
            set { MoscowPopulation = value; }
        }
        public Moscow(int population)
        {
            MoscowPopulation = population;
        }
    }
}
