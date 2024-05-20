using SOLID.HandsOn_W16.Chatrooms;

namespace SOLID.HandsOn_W16.Beatles;

public interface IBeatle
{
	string Name { get; set; }
	void Send(string reciever);
	void Receive(string sender);
	void SetChatroom(IChatroom chatroom);
}