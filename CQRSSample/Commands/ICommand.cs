using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSSample.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
