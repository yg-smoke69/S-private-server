using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001478")]
public class DetailedTCStats
{
	[Token(Token = "0x4008E12")]
	[FieldOffset(Offset = "0x8")]
	public uint mvp_count;

	[Token(Token = "0x4008E13")]
	[FieldOffset(Offset = "0xC")]
	public uint double_kills;

	[Token(Token = "0x4008E14")]
	[FieldOffset(Offset = "0x10")]
	public uint triple_kills;

	[Token(Token = "0x4008E15")]
	[FieldOffset(Offset = "0x14")]
	public uint four_kills;

	[Token(Token = "0x4008E16")]
	[FieldOffset(Offset = "0x18")]
	public uint damage;

	[Token(Token = "0x4008E17")]
	[FieldOffset(Offset = "0x1C")]
	public uint head_shot_kills;

	[Token(Token = "0x4008E18")]
	[FieldOffset(Offset = "0x20")]
	public uint knock_downs;

	[Token(Token = "0x4008E19")]
	[FieldOffset(Offset = "0x24")]
	public uint revivals;

	[Token(Token = "0x4008E1A")]
	[FieldOffset(Offset = "0x28")]
	public uint assists;

	[Token(Token = "0x4008E1B")]
	[FieldOffset(Offset = "0x2C")]
	public uint deaths;

	[Token(Token = "0x6007B05")]
	[Address(RVA = "0x309E6D0", Offset = "0x309E6D0", VA = "0x309E6D0")]
	public DetailedTCStats()
	{
	}
}
