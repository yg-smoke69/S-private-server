using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A63")]
public class DispatchSettingDesc
{
	[Token(Token = "0x400A52E")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x400A52F")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A530")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A531")]
	[FieldOffset(Offset = "0x14")]
	public uint max_quest_line;

	[Token(Token = "0x60080C0")]
	[Address(RVA = "0x309F0E8", Offset = "0x309F0E8", VA = "0x309F0E8")]
	public DispatchSettingDesc()
	{
	}
}
