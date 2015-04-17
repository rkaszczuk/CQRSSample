using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSSample.Commands
{
    public class CreateUserCommand : Command
    {
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int StreetNumber { get; private set; }

        public CreateUserCommand(Guid id, string name, string city, string street, int streetNumber)
            : base(id)
        {
            Name = name;
            City = city;
            Street = street;
            StreetNumber = streetNumber;
        }
    }
}
