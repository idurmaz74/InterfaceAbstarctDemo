using InterfaceAbstarctDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstarctDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
