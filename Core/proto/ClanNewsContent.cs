using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013BB")]
public class ClanNewsContent
{
	[Token(Token = "0x4008AE5")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008AE6")]
	[FieldOffset(Offset = "0x10")]
	public uint member_type;

	[Token(Token = "0x4008AE7")]
	[FieldOffset(Offset = "0x14")]
	public uint level;

	[Token(Token = "0x6007AA6")]
	[Address(RVA = "0x309BE74", Offset = "0x309BE74", VA = "0x309BE74")]
	public ClanNewsContent()
	{
	}
}
