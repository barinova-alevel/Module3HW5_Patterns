using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Participant
    {
        ChatroomConcreteMediator chatroom;
        string name;
        
        public Participant(string name)
        {
            this.name = name;
        }
       
        public string Name
        {
            get { return name; }
        }
        
        public ChatroomConcreteMediator Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }
        
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }
        
        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}
