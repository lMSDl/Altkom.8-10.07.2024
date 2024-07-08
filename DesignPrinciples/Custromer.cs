namespace Altkom._8_10._07._2024.DesignPrinciples
{
    public class Custromer
    {
        public Custromer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        public bool IsActive { get; set; }

        private float GetBalance()
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
