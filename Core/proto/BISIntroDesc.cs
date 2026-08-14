using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCA")]
public class BISIntroDesc
{
	[Token(Token = "0x400AEDB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEDC")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400AEDD")]
	[FieldOffset(Offset = "0x10")]
	public string cdn_link;

	[Token(Token = "0x6008225")]
	[Address(RVA = "0x317B518", Offset = "0x317B518", VA = "0x317B518")]
	public BISIntroDesc()
	{
	}
}
