using Contratos.Entities;
using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Services
{
    internal class ContractService
    {
        static public List<Installment> generateInstallments(double price, DateTime date, int installments, Partner partner)
        {
            Interest interest = new();

            List<Installment> installmentsList = new List<Installment>();
            for (int installment = 1; installment <= installments; installment++)
            {
                double priceInstallment = price / installments;
                double priceWithInterest = priceInstallment + (priceInstallment * interest.Tax) * installment;
                double partnerInterest = (priceWithInterest * partner.Tax);

                installmentsList.Add(new Installment(installment, date, priceWithInterest + partnerInterest));
            }
            return installmentsList;
        }

        static public void saveInstallmentOnContract(Contract contract, List<Installment> installmentsList)
        {
            contract.Installments = installmentsList;
        }
    }
}
