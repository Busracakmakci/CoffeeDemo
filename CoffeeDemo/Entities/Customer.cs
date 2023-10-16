using CoffeeDemo.Abstract;

namespace CoffeeDemo.Entities

{
    public class Customer : IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationlityId { get; set; }
        public bool NationalityId { get; internal set; }
    }
}

