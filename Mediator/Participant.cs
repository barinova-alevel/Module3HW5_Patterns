namespace Mediator
{
    using System;

    public class Participant
    {
        private ChatroomConcreteMediator chatroom;
        private string name;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public ChatroomConcreteMediator Chatroom
        {
            get { return this.chatroom; }
            set { this.chatroom = value; }
        }

        public void Send(string to, string message)
        {
            this.chatroom.Send(this.name, to, message);
        }

        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine(
                "{0} to {1}: '{2}'",
                from, Name, message);
        }

        public override bool Equals(object obj)
        {
            return obj is Participant participant &&
                   this.Name == participant.Name;
        }
    }
}
