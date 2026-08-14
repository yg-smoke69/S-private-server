using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001647")]
public class ClanLuckyBag
{
	[Token(Token = "0x40095B9")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x40095BA")]
	[FieldOffset(Offset = "0x10")]
	public ulong bag_id;

	[Token(Token = "0x40095BB")]
	[FieldOffset(Offset = "0x18")]
	public ulong creater_id;

	[Token(Token = "0x40095BC")]
	[FieldOffset(Offset = "0x20")]
	public ulong created_at;

	[Token(Token = "0x40095BD")]
	[FieldOffset(Offset = "0x28")]
	public uint total_num;

	[Token(Token = "0x40095BE")]
	[FieldOffset(Offset = "0x2C")]
	public uint taken_num;

	[Token(Token = "0x40095BF")]
	[FieldOffset(Offset = "0x30")]
	public uint reason;

	[Token(Token = "0x40095C0")]
	[FieldOffset(Offset = "0x34")]
	public uint level;

	[Token(Token = "0x6007C91")]
	[Address(RVA = "0x309BC8C", Offset = "0x309BC8C", VA = "0x309BC8C")]
	public ClanLuckyBag()
	{
	}
}
