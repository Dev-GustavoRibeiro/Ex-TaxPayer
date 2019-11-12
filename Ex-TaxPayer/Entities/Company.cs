namespace Ex_TaxPayer.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualincome, int numberOfEmployees) : base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return (AnualIncome * 14.0) / 100;
            }
            else
            {
                return (AnualIncome * 16.0) / 100;
            }
        }
    }
}
