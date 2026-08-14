using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030B1")]
public class ClientInGameChatMessage
{
	[Token(Token = "0x4012856")]
	[FieldOffset(Offset = "0x8")]
	public string NickName;

	[Token(Token = "0x4012857")]
	[FieldOffset(Offset = "0xC")]
	public string MessageContent;

	[Token(Token = "0x601461D")]
	[Address(RVA = "0x172C418", Offset = "0x172C418", VA = "0x172C418")]
	public ClientInGameChatMessage()
	{
	}
}
