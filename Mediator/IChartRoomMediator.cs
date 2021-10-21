using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IChartRoomMediator
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
    }
}
