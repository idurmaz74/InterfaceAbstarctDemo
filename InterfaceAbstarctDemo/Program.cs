using InterfaceAbstarctDemo.Abstract;
using InterfaceAbstarctDemo.Concrete;
using InterfaceAbstarctDemo.Entities;
using InterfaceAbstarctDemo.Adapters;
using System;

namespace InterfaceAbstarctDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManagerNero=new NeroCustomerManager();
            customerManagerNero.Save(new Customer
            {
                DateOfBirth=new DateTime(1998,11,12),
                FirstName="Buğrahan",
                LastName="Durmaz",
                NationalityId="30757997186"
            });

            BaseCustomerManager customerManagerStarbucks = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManagerStarbucks.Save(new Customer
            {
                DateOfBirth = new DateTime(1998, 11, 12),
                FirstName = "Buğrahan",
                LastName = "Durmaz",
                NationalityId = "30757997186"
            });
        }
    }
}
