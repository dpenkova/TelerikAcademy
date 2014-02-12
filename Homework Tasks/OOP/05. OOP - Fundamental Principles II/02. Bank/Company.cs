namespace Bank
{
    class Company : Customer
    {
        public string EIK { get; protected set; }

        public Company(string name, string eik)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException("Customer name cannot be null or empty string.");
            }
            this.Name = name;

            if (string.IsNullOrEmpty(eik) || string.IsNullOrWhiteSpace(eik))
            {
                throw new System.ArgumentException("Customer EIK cannot be null or empty string.");
            }
            this.EIK = eik;
        }
    }
}
