using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bf_banca_2
{
    internal class banca
    {
        private string secret;

        public banca() { secret = "Ci@o"; }

        [MethodImpl(MethodImplOptions.Synchronized)]

        public bool Login(string test) { return secret == test; }
    }
}
