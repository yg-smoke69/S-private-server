using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019EC")]
public class EmulatorSettingDesc
{
	[Token(Token = "0x400A2CB")]
	[FieldOffset(Offset = "0x8")]
	public uint limit_score;

	[Token(Token = "0x400A2CC")]
	[FieldOffset(Offset = "0xC")]
	public uint match_mode;

	[Token(Token = "0x400A2CD")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400A2CE")]
	[FieldOffset(Offset = "0x14")]
	public EEmulator.MatchMakingMethodType emulator_method;

	[Token(Token = "0x6008044")]
	[Address(RVA = "0x309F93C", Offset = "0x309F93C", VA = "0x309F93C")]
	public EmulatorSettingDesc()
	{
	}
}
