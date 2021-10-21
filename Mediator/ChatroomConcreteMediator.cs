using System.Collections.Generic;

namespace Mediator
{
   public class ChatroomConcreteMediator : IChartRoomMediator
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        public void Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }
        public void Send(string from, string to, string message)
        {
            Participant participant = participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
