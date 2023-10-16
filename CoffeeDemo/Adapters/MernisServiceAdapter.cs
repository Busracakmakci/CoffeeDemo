using CoffeeDemo.Abstract;
using CoffeeDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference1.KPSPublicSoapClient;

namespace CoffeeDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new  MernisServiceReference.KPSPublicSoapClient();
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }

}
