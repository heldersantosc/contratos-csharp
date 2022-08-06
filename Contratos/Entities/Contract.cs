

namespace Contratos.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public List<Installment> Installments = new();

        public Contract(int number, DateTime date, double price)
        {
            Number = number;
            Date = date;
            Price = price;
        }

        public Contract(int number, DateTime date, double price, List<Installment> installments)
        {
            Number = number;
            Date = date;
            Price = price;
            Installments = installments;
        }

    }
}
