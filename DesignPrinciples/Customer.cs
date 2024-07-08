namespace Altkom._8_10._07._2024.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public bool IsActive { get; set; }

        public PaymentAccount Account { get; } = new PaymentAccount();
    }
}
