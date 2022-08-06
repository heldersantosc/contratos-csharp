using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Services
{
    internal class Paypal: Partner
    {
        public double Tax { get; }

        public Paypal()
        {
            this.Tax = 0.02;
        }
    }
}
