using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatroomConcreteMediator chatroom = new ChatroomConcreteMediator();
            
            Participant George = new BeatleConcreteHandler("George");
            Participant Paul = new BeatleConcreteHandler("Paul");
            Participant Ringo = new BeatleConcreteHandler("Ringo");
            Participant John = new BeatleConcreteHandler("John");
            Participant Yoko = new NonBeatleConcreteHandler("Yoko");
            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "Hi Ringo!");
            Ringo.Send("George", "Hi George");
            Paul.Send("John", "Hi John");
            John.Send("Yoko", "Hi Yoko");
            
            Console.ReadKey();
        }
    }
}
