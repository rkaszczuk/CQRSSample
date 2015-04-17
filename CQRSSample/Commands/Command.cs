using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSSample.Commands
{
    public class Command : ICommand
    {
        public Guid Id { get; private set; }
        public Command(Guid id)
        {
            Id = id;
        }
    }
}
