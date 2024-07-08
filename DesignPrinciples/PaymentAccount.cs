namespace Altkom._8_10._07._2024.DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        public float GetBalance()
        {
            return Income - Outcome;
        }

        public bool Charge(float amount)
        {
            if (GetBalance() + AllowedDebit < amount)
            {
                return false;
            }

            Outcome += amount;
            return true;
        }


        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}
