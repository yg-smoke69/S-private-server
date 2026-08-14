using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013FE")]
public class ItemProbability
{
	[Token(Token = "0x4008BDC")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x4008BDD")]
	[FieldOffset(Offset = "0xC")]
	public Item item;

	[Token(Token = "0x4008BDE")]
	[FieldOffset(Offset = "0x10")]
	public uint probability;

	[Token(Token = "0x6007AD4")]
	[Address(RVA = "0x30A4104", Offset = "0x30A4104", VA = "0x30A4104")]
	public ItemProbability()
	{
	}
}
