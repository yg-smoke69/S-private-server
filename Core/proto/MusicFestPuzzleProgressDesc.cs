using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBE")]
public class MusicFestPuzzleProgressDesc
{
	[Token(Token = "0x400AEA4")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEA5")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_num;

	[Token(Token = "0x400AEA6")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award;

	[Token(Token = "0x6008219")]
	[Address(RVA = "0x30A939C", Offset = "0x30A939C", VA = "0x30A939C")]
	public MusicFestPuzzleProgressDesc()
	{
	}
}
