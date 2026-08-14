using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200185C")]
public class CSWinterFestStrategyFinishOrderRes
{
	[Token(Token = "0x4009CDA")]
	[FieldOffset(Offset = "0x8")]
	public MiniGameItem products;

	[Token(Token = "0x4009CDB")]
	[FieldOffset(Offset = "0xC")]
	public Item rewards;

	[Token(Token = "0x4009CDC")]
	[FieldOffset(Offset = "0x10")]
	public uint current_other_order;

	[Token(Token = "0x4009CDD")]
	[FieldOffset(Offset = "0x14")]
	public uint devote_points;

	[Token(Token = "0x6007EB5")]
	[Address(RVA = "0x309AAD0", Offset = "0x309AAD0", VA = "0x309AAD0")]
	public CSWinterFestStrategyFinishOrderRes()
	{
	}
}
