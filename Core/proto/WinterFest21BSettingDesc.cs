using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B98")]
public class WinterFest21BSettingDesc
{
	[Token(Token = "0x400AD94")]
	[FieldOffset(Offset = "0x8")]
	public uint sugar_token_id;

	[Token(Token = "0x400AD95")]
	[FieldOffset(Offset = "0xC")]
	public uint exchange_token_id;

	[Token(Token = "0x400AD96")]
	[FieldOffset(Offset = "0x10")]
	public uint premission_unlock_level;

	[Token(Token = "0x400AD97")]
	[FieldOffset(Offset = "0x18")]
	public long second_period_start_time_stamp;

	[Token(Token = "0x400AD98")]
	[FieldOffset(Offset = "0x20")]
	public string cdn_url;

	[Token(Token = "0x400AD99")]
	[FieldOffset(Offset = "0x28")]
	public long second_mission_start_time_stamp;

	[Token(Token = "0x60081F3")]
	[Address(RVA = "0x33E5A30", Offset = "0x33E5A30", VA = "0x33E5A30")]
	public WinterFest21BSettingDesc()
	{
	}
}
