namespace Ex_TaxPayer.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualincome, double healthExpenditures) : base(name, anualincome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0 && HealthExpenditures <= 0)
            {
                return (AnualIncome * 15.0) / 100;
            }
            else if (AnualIncome < 20000.0 && HealthExpenditures > 0)
            {
                return ((AnualIncome * 15.0) / 100) - ((HealthExpenditures * 50.0)/100);
            }
            else if (AnualIncome >= 20000.0 && HealthExpenditures <=0)
            {
                return (AnualIncome * 25.0) / 100;
            }
            else
            {
                return ((AnualIncome * 25.0) / 100) - ((HealthExpenditures * 50.0) / 100);
            }
        }
    }
}
