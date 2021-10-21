using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class NonBeatleConcreteHandler : Participant
    {
        public NonBeatleConcreteHandler(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
