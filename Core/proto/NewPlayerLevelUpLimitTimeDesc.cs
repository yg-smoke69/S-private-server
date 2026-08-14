using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0A")]
public class NewPlayerLevelUpLimitTimeDesc
{
	[Token(Token = "0x400A33F")]
	[FieldOffset(Offset = "0x8")]
	public ulong date_ob19_timestamp;

	[Token(Token = "0x400A340")]
	[FieldOffset(Offset = "0x10")]
	public ulong date_cut_apart_timestamp;

	[Token(Token = "0x400A341")]
	[FieldOffset(Offset = "0x18")]
	public ulong new_player_days;

	[Token(Token = "0x400A342")]
	[FieldOffset(Offset = "0x20")]
	public string date_ob19;

	[Token(Token = "0x400A343")]
	[FieldOffset(Offset = "0x24")]
	public string date_cut_apart;

	[Token(Token = "0x400A344")]
	[FieldOffset(Offset = "0x28")]
	public ulong date_ob32_timestamp;

	[Token(Token = "0x6008062")]
	[Address(RVA = "0x30A9D38", Offset = "0x30A9D38", VA = "0x30A9D38")]
	public NewPlayerLevelUpLimitTimeDesc()
	{
	}
}
