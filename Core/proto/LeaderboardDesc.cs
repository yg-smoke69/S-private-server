using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A65")]
public class LeaderboardDesc
{
	[Token(Token = "0x400A53A")]
	[FieldOffset(Offset = "0x8")]
	public uint main_type;

	[Token(Token = "0x400A53B")]
	[FieldOffset(Offset = "0xC")]
	public uint order;

	[Token(Token = "0x400A53C")]
	[FieldOffset(Offset = "0x10")]
	public uint size;

	[Token(Token = "0x400A53D")]
	[FieldOffset(Offset = "0x14")]
	public uint starting_value;

	[Token(Token = "0x400A53E")]
	[FieldOffset(Offset = "0x18")]
	public bool if_estimate;

	[Token(Token = "0x60080C2")]
	[Address(RVA = "0x30A444C", Offset = "0x30A444C", VA = "0x30A444C")]
	public LeaderboardDesc()
	{
	}
}
