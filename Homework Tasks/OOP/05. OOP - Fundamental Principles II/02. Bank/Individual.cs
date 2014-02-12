namespace Bank
{
    class Individual : Customer
    {
        public string EGN { get; protected set; }

        public Individual(string name, string egn)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException("Customer name cannot be null or empty string.");
            }

            this.Name = name;

            if (string.IsNullOrEmpty(egn) || string.IsNullOrWhiteSpace(egn))
            {
                throw new System.ArgumentException("Customer EGN cannot be null or empty string.");
            }

            this.EGN = egn;
        }
    }
}
