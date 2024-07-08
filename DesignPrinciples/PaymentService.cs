namespace Altkom._8_10._07._2024.DesignPrinciples
{

    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            return customer?.Account.Charge(amount) ?? false;
        }

        public void Fund(Customer customer, float amount)
        {
            customer?.Account.Fund(amount);
        }
    }
}
