using SOLID.HandsOn_W16.Beatles;

namespace SOLID.HandsOn_W16.Chatrooms;


// Mediator Pattern
public class Chatroom : IChatroom
{
	private List<IBeatle> _beatles = new();
	public void Register(IBeatle beatle)
	{
		_beatles.Add(beatle);
	}

	public void Unregister(IBeatle beatle)
	{
		_beatles.Remove(beatle);
	}

	public void Send(string receiver, string sender)
	{
		_beatles.First(b => b.Name == receiver).Receive(sender);
	}

}