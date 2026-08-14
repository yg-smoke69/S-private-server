using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164B")]
public class CSDrawClanLuckyBagRes
{
	[Token(Token = "0x40095D3")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40095D4")]
	[FieldOffset(Offset = "0x10")]
	public ulong bag_id;

	[Token(Token = "0x40095D5")]
	[FieldOffset(Offset = "0x18")]
	public AwardData award_data;

	[Token(Token = "0x40095D6")]
	[FieldOffset(Offset = "0x1C")]
	public uint awarded_points;

	[Token(Token = "0x40095D7")]
	[FieldOffset(Offset = "0x20")]
	public uint total_points;

	[Token(Token = "0x40095D8")]
	[FieldOffset(Offset = "0x24")]
	public EClan.LuckyBagType lucky_bag_type;

	[Token(Token = "0x40095D9")]
	[FieldOffset(Offset = "0x28")]
	public bool is_double;

	[Token(Token = "0x6007C95")]
	[Address(RVA = "0x317FB70", Offset = "0x317FB70", VA = "0x317FB70")]
	public CSDrawClanLuckyBagRes()
	{
	}
}
