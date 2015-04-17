using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSSample.Commands
{
    public class RenameUserCommand : Command
    {
        public string NewName { get; private set; }
        public RenameUserCommand(Guid id, string newName)
            :base(id)
        {
            NewName = newName;
        }
    }
}
