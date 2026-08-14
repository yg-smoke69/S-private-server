using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013BC")]
public class ClanNews
{
	[Token(Token = "0x4008AE8")]
	[FieldOffset(Offset = "0x8")]
	public EClan.NewsType type;

	[Token(Token = "0x4008AE9")]
	[FieldOffset(Offset = "0xC")]
	public ClanNewsContent content;

	[Token(Token = "0x4008AEA")]
	[FieldOffset(Offset = "0x10")]
	public ulong update_time;

	[Token(Token = "0x6007AA7")]
	[Address(RVA = "0x309BE6C", Offset = "0x309BE6C", VA = "0x309BE6C")]
	public ClanNews()
	{
	}
}
