using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017FB")]
public class HelpPlayer
{
	[Token(Token = "0x4009BD4")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009BD5")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x6007E55")]
	[Address(RVA = "0x30A2F1C", Offset = "0x30A2F1C", VA = "0x30A2F1C")]
	public HelpPlayer()
	{
	}
}
