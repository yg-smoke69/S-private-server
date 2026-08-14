using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D2")]
public class FittingSlot
{
	[Token(Token = "0x4009458")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009459")]
	[FieldOffset(Offset = "0xC")]
	public uint[] item_ids;

	[Token(Token = "0x400945A")]
	[FieldOffset(Offset = "0x10")]
	public uint[] invalid_item_ids;

	[Token(Token = "0x6007C1C")]
	[Address(RVA = "0x30A0D6C", Offset = "0x30A0D6C", VA = "0x30A0D6C")]
	public FittingSlot()
	{
	}
}
