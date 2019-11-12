namespace Ex_TaxPayer.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }

        public abstract double Tax();
    }
}
