using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CC2")]
public struct PVEProperty
{
	[Token(Token = "0x4011154")]
	[FieldOffset(Offset = "0x0")]
	public string description;

	[Token(Token = "0x4011155")]
	[FieldOffset(Offset = "0x4")]
	public int property_value;

	[Token(Token = "0x4011156")]
	[FieldOffset(Offset = "0x8")]
	public int block_num;

	[Token(Token = "0x6012BD4")]
	[Address(RVA = "0x93D4A0", Offset = "0x93D4A0", VA = "0x93D4A0")]
	public PVEProperty(string desc, int v, int b)
	{
	}
}
