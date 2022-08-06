

using Contratos.Entities;
using Contratos.Services;

namespace Contratos
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Enter Contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): " + DateTime.Now);
            DateTime contractDate = DateTime.Now;
            //DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("\nPrice (R$): ");
            double contractPrice = double.Parse(Console.ReadLine());
            Console.Write("Installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractPrice);

            List<Installment> installmentsList = ContractService.generateInstallments(contract.Price, contract.Date, installments, new Paypal());
            ContractService.saveInstallmentOnContract(contract, installmentsList);

            foreach (Installment installment in contract.Installments)
            {
                Console.Write(installment);
            }
        }
    }
}