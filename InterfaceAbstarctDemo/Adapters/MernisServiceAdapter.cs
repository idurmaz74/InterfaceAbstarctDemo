using InterfaceAbstarctDemo.Abstract;
using InterfaceAbstarctDemo.Entities;
using InterfaceAbstarctDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace InterfaceAbstarctDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        Convert.ToInt64(customer.NationalityId),
                        customer.FirstName.ToUpper(),
                        customer.LastName.ToUpper(),
                        customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
