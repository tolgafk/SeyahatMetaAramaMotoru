using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    public class Passenger : Person
    {
        private string tc;
        public string getTc() { return tc; }
        private void setTc(string tc) { this.tc = tc; }

        private string dg;
        public string getDg() { return dg; }
        private void setDg(string dg) { this.dg = dg; }

        public Passenger(string name, string surname, string tc, string dg)
        {
            setName(name);
            setSurname(surname);
            setTc(tc);
            setDg(dg);
        }
    }
}
