using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E5")]
public class ClanLuckyBagInfo
{
	[Token(Token = "0x4009023")]
	[FieldOffset(Offset = "0x8")]
	public ulong bag_id;

	[Token(Token = "0x4009024")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x4009025")]
	[FieldOffset(Offset = "0x18")]
	public long created_at;

	[Token(Token = "0x4009026")]
	[FieldOffset(Offset = "0x20")]
	public ulong creater_id;

	[Token(Token = "0x6007B3A")]
	[Address(RVA = "0x309BCA4", Offset = "0x309BCA4", VA = "0x309BCA4")]
	public ClanLuckyBagInfo()
	{
	}
}
