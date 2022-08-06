using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Entities
{
    internal class Installment
    {
        int installment;
        DateTime date;
        double price;

        public Installment(int installment, DateTime date, double price)
        {
            this.installment = installment;
            this.date = date;
            this.price = price;
        }

        public override string ToString()
        {
            return "\nInstallment: " + installment 
                + "\nDate: " + date.ToString()
                + "\nPreço: " + price
                + "\n";
        }

    }
}
