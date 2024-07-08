namespace Altkom._8_10._07._2024.DesignPrinciples
{

    public class CustomersService
    {
        private ICollection<Customer> Customers { get; } = [new Customer(1) { IsActive = true }, new Customer(2), new Customer(3), new Customer(4), new Customer(5)];

        public Customer? FingById(int customerId)
        {
            return Customers.Where(x => x.IsActive).Where(x => x.Id == customerId).SingleOrDefault();
        }
    }
}
