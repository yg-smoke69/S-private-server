using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4F")]
public class NewbieScore
{
	[Token(Token = "0x400A4D2")]
	[FieldOffset(Offset = "0x8")]
	public uint min_score;

	[Token(Token = "0x400A4D3")]
	[FieldOffset(Offset = "0xC")]
	public uint max_score;

	[Token(Token = "0x400A4D4")]
	[FieldOffset(Offset = "0x10")]
	public int newbie_score;

	[Token(Token = "0x400A4D5")]
	[FieldOffset(Offset = "0x14")]
	public int first_win_score;

	[Token(Token = "0x400A4D6")]
	[FieldOffset(Offset = "0x18")]
	public double daily_mission_scale;

	[Token(Token = "0x60080A7")]
	[Address(RVA = "0x33DE898", Offset = "0x33DE898", VA = "0x33DE898")]
	public NewbieScore()
	{
	}
}
