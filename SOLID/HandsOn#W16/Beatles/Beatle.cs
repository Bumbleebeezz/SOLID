using SOLID.HandsOn_W16.Chatrooms;

namespace SOLID.HandsOn_W16.Beatles;

public class Beatle : IBeatle
{
	public string Name { get; set; }
	private IChatroom _chatroom { get; set; }
	public void Send(string reciever)
	{
		_chatroom.Send(reciever,Name);
	}

	public void Receive(string sender)
	{
		Console.WriteLine($"To a beatle {Name}, from {sender}");
	}

	public void SetChatroom(IChatroom chatroom)
	{
		Chatroom = chatroom;
		Chatroom.Register(Name);
	}
}