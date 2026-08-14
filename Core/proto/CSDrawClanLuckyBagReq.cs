using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164A")]
public class CSDrawClanLuckyBagReq
{
	[Token(Token = "0x40095CD")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x40095CE")]
	[FieldOffset(Offset = "0x10")]
	public ulong bag_id;

	[Token(Token = "0x40095CF")]
	[FieldOffset(Offset = "0x18")]
	public uint level;

	[Token(Token = "0x40095D0")]
	[FieldOffset(Offset = "0x1C")]
	public EClan.LuckyBagType luck_bag_type;

	[Token(Token = "0x40095D1")]
	[FieldOffset(Offset = "0x20")]
	public long created_at;

	[Token(Token = "0x40095D2")]
	[FieldOffset(Offset = "0x28")]
	public ulong creater_id;

	[Token(Token = "0x6007C94")]
	[Address(RVA = "0x317FB68", Offset = "0x317FB68", VA = "0x317FB68")]
	public CSDrawClanLuckyBagReq()
	{
	}
}
