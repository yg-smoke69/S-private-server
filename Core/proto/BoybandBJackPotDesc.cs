using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BFF")]
public class BoybandBJackPotDesc
{
	[Token(Token = "0x400B033")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400B034")]
	[FieldOffset(Offset = "0xC")]
	public uint reward_item_id;

	[Token(Token = "0x400B035")]
	[FieldOffset(Offset = "0x10")]
	public uint reward_num;

	[Token(Token = "0x400B036")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x400B037")]
	[FieldOffset(Offset = "0x18")]
	public uint sort_id;

	[Token(Token = "0x400B038")]
	[FieldOffset(Offset = "0x1C")]
	public string resource_id;

	[Token(Token = "0x600825A")]
	[Address(RVA = "0x317D2D0", Offset = "0x317D2D0", VA = "0x317D2D0")]
	public BoybandBJackPotDesc()
	{
	}
}
