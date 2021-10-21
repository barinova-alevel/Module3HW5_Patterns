
namespace Mediator
{
    using System.Collections.Generic;

    public class ChatroomConcreteMediator : IChartRoomMediator
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!this.participants.ContainsValue(participant))
            {
                this.participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            Participant participant = this.participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
