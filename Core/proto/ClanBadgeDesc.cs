using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A38")]
public class ClanBadgeDesc
{
	[Token(Token = "0x400A425")]
	[FieldOffset(Offset = "0x8")]
	public uint badge_id;

	[Token(Token = "0x400A426")]
	[FieldOffset(Offset = "0xC")]
	public bool is_default;

	[Token(Token = "0x400A427")]
	[FieldOffset(Offset = "0x10")]
	public uint unlock_cdt;

	[Token(Token = "0x400A428")]
	[FieldOffset(Offset = "0x14")]
	public uint unlock_cdt_value;

	[Token(Token = "0x400A429")]
	[FieldOffset(Offset = "0x18")]
	public uint badge_available_time;

	[Token(Token = "0x6008090")]
	[Address(RVA = "0x309B838", Offset = "0x309B838", VA = "0x309B838")]
	public ClanBadgeDesc()
	{
	}
}
