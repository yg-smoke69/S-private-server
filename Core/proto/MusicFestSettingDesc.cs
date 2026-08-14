using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB9")]
public class MusicFestSettingDesc
{
	[Token(Token = "0x400AE82")]
	[FieldOffset(Offset = "0x8")]
	public uint donate_time;

	[Token(Token = "0x400AE83")]
	[FieldOffset(Offset = "0xC")]
	public uint demand_time;

	[Token(Token = "0x400AE84")]
	[FieldOffset(Offset = "0x10")]
	public uint token_id;

	[Token(Token = "0x6008214")]
	[Address(RVA = "0x30A93AC", Offset = "0x30A93AC", VA = "0x30A93AC")]
	public MusicFestSettingDesc()
	{
	}
}
