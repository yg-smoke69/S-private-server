using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ADB")]
public class CardImageDesc
{
	[Token(Token = "0x400A8F0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A8F1")]
	[FieldOffset(Offset = "0xC")]
	public string img_url;

	[Token(Token = "0x6008137")]
	[Address(RVA = "0x309AB98", Offset = "0x309AB98", VA = "0x309AB98")]
	public CardImageDesc()
	{
	}
}
