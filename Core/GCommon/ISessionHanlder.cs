using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200407B")]
public interface ISessionHanlder
{
	[Token(Token = "0x601A3A2")]
	void OnConnected(bool result);

	[Token(Token = "0x601A3A3")]
	void OnDisconnected(DisconnectedReason reason = DisconnectedReason.Unknown);

	[Token(Token = "0x601A3A4")]
	void OnPingSent(int lastSentTime);
}
