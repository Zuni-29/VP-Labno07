using System;
using System.Collections.Generic;
using System.Text;

namespace Taskno4_PartA
{
    public interface INotification
    {
        string Channel { get; }

        void Send(string message);
    }
}
