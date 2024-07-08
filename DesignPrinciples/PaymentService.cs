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
            var customer = FingById(customerId);
            if (customer == null)
            {
                return false;
            }

            if (GetBalance(customerId) + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        public void Fund(int customerId, float amount)
        {
            Custromer? customer = FingById(customerId);
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int customerId)
        {
            var customer = FingById(customerId);
            return customer?.Income - customer?.Outcome;
        }

        private Custromer? FingById(int customerId)
        {
            return Customers.Where(x => x.IsActive).Where(x => x.Id == customerId).SingleOrDefault();
        }
    }
}
