using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200136F")]
public class MailGlobalDropInfo
{
	[Token(Token = "0x400895C")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400895D")]
	[FieldOffset(Offset = "0xC")]
	public string url;

	[Token(Token = "0x400895E")]
	[FieldOffset(Offset = "0x10")]
	public uint award_time;

	[Token(Token = "0x6007A70")]
	[Address(RVA = "0x30A7420", Offset = "0x30A7420", VA = "0x30A7420")]
	public MailGlobalDropInfo()
	{
	}
}
