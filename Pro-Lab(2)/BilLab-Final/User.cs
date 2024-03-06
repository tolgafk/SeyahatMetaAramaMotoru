using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilLab_Final
{
    internal abstract class User : ILoginable
    {
        public abstract int Login(string a, string b);
    }
}
