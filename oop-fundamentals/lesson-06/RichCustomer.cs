namespace lesson_06
{
    class RichCustomer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }

        public RichCustomer(int id, string name, string address)
        {

            /*if (id < 0)
            {
                throw new InvalidOperationException("Id must be greater than 0");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidOperationException("Name must be not empty");
            }

            if (string.IsNullOrEmpty(address))
            {
                throw new InvalidOperationException("Address must be not empty");
            }*/

            DomainExceptionValidation.When(id < 0, "Id must be greater than 0");
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name must be not empty");
            DomainExceptionValidation.When(string.IsNullOrEmpty(address), "Address must be not empty");

            Id = id;
            Name = name;
            Address = address;
        }

    }
}