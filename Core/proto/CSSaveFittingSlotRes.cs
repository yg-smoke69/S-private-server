using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D0")]
public class CSSaveFittingSlotRes
{
	[Token(Token = "0x4009455")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009456")]
	[FieldOffset(Offset = "0xC")]
	public uint[] item_ids;

	[Token(Token = "0x6007C1A")]
	[Address(RVA = "0x3099568", Offset = "0x3099568", VA = "0x3099568")]
	public CSSaveFittingSlotRes()
	{
	}
}
