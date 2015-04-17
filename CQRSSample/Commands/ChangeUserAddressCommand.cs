using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSSample.Commands
{
    public class ChangeUserAddressCommand : Command
    {
        public string NewCity { get; private set; }
        public string NewStreet { get; private set; }
        public int NewStreetNumber { get; private set; }
        public ChangeUserAddressCommand(Guid id, string newCity, string newStreet, int newStreetNumber)
            :base(id)
        {
            NewCity = newCity;
            NewStreet = newStreet;
            NewStreetNumber = newStreetNumber;
        }

    }
}
