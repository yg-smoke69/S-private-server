using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001760")]
public class MysteryShopProbability
{
	[Token(Token = "0x4009A1C")]
	[FieldOffset(Offset = "0x8")]
	public uint mystery_shop_id;

	[Token(Token = "0x4009A1D")]
	[FieldOffset(Offset = "0xC")]
	public uint start_stage;

	[Token(Token = "0x4009A1E")]
	[FieldOffset(Offset = "0x10")]
	public uint end_stage;

	[Token(Token = "0x4009A1F")]
	[FieldOffset(Offset = "0x14")]
	public uint probability;

	[Token(Token = "0x6007DBA")]
	[Address(RVA = "0x30A9B14", Offset = "0x30A9B14", VA = "0x30A9B14")]
	public MysteryShopProbability()
	{
	}
}
