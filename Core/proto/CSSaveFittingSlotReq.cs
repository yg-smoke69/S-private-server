using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015CF")]
public class CSSaveFittingSlotReq
{
	[Token(Token = "0x4009453")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4009454")]
	[FieldOffset(Offset = "0xC")]
	public uint[] item_ids;

	[Token(Token = "0x6007C19")]
	[Address(RVA = "0x3099560", Offset = "0x3099560", VA = "0x3099560")]
	public CSSaveFittingSlotReq()
	{
	}
}
