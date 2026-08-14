using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE5")]
public class EmulatorScoreDesc
{
	[Token(Token = "0x400A924")]
	[FieldOffset(Offset = "0x8")]
	public bool check_emulator;

	[Token(Token = "0x400A925")]
	[FieldOffset(Offset = "0xC")]
	public uint no_sensor_score;

	[Token(Token = "0x400A926")]
	[FieldOffset(Offset = "0x10")]
	public uint root_no_sensor_score;

	[Token(Token = "0x6008140")]
	[Address(RVA = "0x309F934", Offset = "0x309F934", VA = "0x309F934")]
	public EmulatorScoreDesc()
	{
	}
}
