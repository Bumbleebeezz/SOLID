using SOLID.HandsOn_W16.Beatles;

namespace SOLID.HandsOn_W16.Chatrooms;

public interface IChatroom
{
	void Register(IBeatle beatle);
	void Unregister(IBeatle beatle);
	void Send(string receiver, string sender);

}