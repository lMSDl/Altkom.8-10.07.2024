namespace Altkom._8_10._07._2024.DesignPrinciples
{

    public class PaymentService
    {
        private ICollection<Custromer> Customers { get; } = [new Custromer(1), new Custromer(2), new Custromer(3), new Custromer(4), new Custromer(5)];

        public bool Charge(int customerId, float amount)
        {
            var customer = FingById(customerId);
            return customer?.Charge(amount) ?? false;
        }

        public void Fund(int customerId, float amount)
        {
            Custromer? customer = FingById(customerId);
            customer?.Fund(amount);
        }

        private Custromer? FingById(int customerId)
        {
            return Customers.Where(x => x.IsActive).Where(x => x.Id == customerId).SingleOrDefault();
        }
    }
}
