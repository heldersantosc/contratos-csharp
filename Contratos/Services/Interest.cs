using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Services
{
    internal class Interest : Partner
    {
        public double Tax { get; }

        public Interest()
        {
            this.Tax = 0.01;
        }
    }
}
