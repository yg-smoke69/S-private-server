using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200138E")]
public class AccountNewsContent
{
	[Token(Token = "0x40089EE")]
	[FieldOffset(Offset = "0x8")]
	public uint[] item_ids;

	[Token(Token = "0x40089EF")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x40089F0")]
	[FieldOffset(Offset = "0x10")]
	public uint match_mode;

	[Token(Token = "0x40089F1")]
	[FieldOffset(Offset = "0x14")]
	public uint map_id;

	[Token(Token = "0x40089F2")]
	[FieldOffset(Offset = "0x18")]
	public uint game_mode;

	[Token(Token = "0x40089F3")]
	[FieldOffset(Offset = "0x1C")]
	public uint group_mode;

	[Token(Token = "0x40089F4")]
	[FieldOffset(Offset = "0x20")]
	public uint treasurebox_id;

	[Token(Token = "0x40089F5")]
	[FieldOffset(Offset = "0x24")]
	public uint commodity_id;

	[Token(Token = "0x40089F6")]
	[FieldOffset(Offset = "0x28")]
	public uint store_id;

	[Token(Token = "0x6007A8A")]
	[Address(RVA = "0x31799F8", Offset = "0x31799F8", VA = "0x31799F8")]
	public AccountNewsContent()
	{
	}
}
