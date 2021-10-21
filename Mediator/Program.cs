namespace Mediator
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ChatroomConcreteMediator chatroom = new ChatroomConcreteMediator();

            Participant george = new BeatleConcreteHandler("George");
            Participant paul = new BeatleConcreteHandler("Paul");
            Participant ringo = new BeatleConcreteHandler("Ringo");
            Participant john = new BeatleConcreteHandler("John");
            Participant yoko = new NonBeatleConcreteHandler("Yoko");
            chatroom.Register(george);
            chatroom.Register(paul);
            chatroom.Register(ringo);
            chatroom.Register(john);
            chatroom.Register(yoko);

            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "Hi Ringo!");
            ringo.Send("George", "Hi George");
            paul.Send("John", "Hi John");
            john.Send("Yoko", "Hi Yoko");

            Console.ReadKey();
        }
    }
}
