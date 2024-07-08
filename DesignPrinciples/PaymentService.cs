namespace Altkom._8_10._07._2024.DesignPrinciples
{

    public class PaymentService
    {
        private ICollection<Custromer> Customers { get; } = [new Custromer(1), new Custromer(2), new Custromer(3), new Custromer(4), new Custromer(5)];

        public bool DeleteCustomer(Custromer customer)
        {
            return Customers.Remove(customer);
        }

        public Custromer FindByAllowedDebit(float allowedDebit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = Customers.SingleOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                return false;
            }

            if (customer.Income - customer.Outcome + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            var customer = Customers.Where(x => x.Id == customerId).SingleOrDefault();
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int customerId)
        {
            var customer = Customers.Where(x => x.Id == customerId).SingleOrDefault();
            return customer?.Income - customer?.Outcome;
        }
    }
}
