using InterfaceAbstarctDemo.Abstract;
using InterfaceAbstarctDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstarctDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
