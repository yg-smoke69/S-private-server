using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB6")]
public class ReturnVirtualItemDesc
{
	[Token(Token = "0x400A817")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A818")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.ItemSourceType source;

	[Token(Token = "0x400A819")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x400A81A")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A81B")]
	[FieldOffset(Offset = "0x18")]
	public uint return_id;

	[Token(Token = "0x400A81C")]
	[FieldOffset(Offset = "0x1C")]
	public uint return_num;

	[Token(Token = "0x6008113")]
	[Address(RVA = "0x33E1A10", Offset = "0x33E1A10", VA = "0x33E1A10")]
	public ReturnVirtualItemDesc()
	{
	}
}
