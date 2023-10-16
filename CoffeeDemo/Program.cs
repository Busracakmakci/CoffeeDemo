using CoffeeDemo.Abstract;
using CoffeeDemo.Adapters;
using CoffeeDemo.Concrete;
using CoffeeDemo.Entities;

namespace InterfaceAbstractDemo

{
   public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth= new DateTime(2000,12,08), FirstName="busra", LastName="cakmakci", NationlityId="235465678"});
            Console.ReadLine();
        }
    }
}
