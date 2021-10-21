namespace Mediator
{
    using System;

    public class BeatleConcreteHandler : Participant
    {
        public BeatleConcreteHandler(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
