using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A39")]
public class ClanWarMMRDesc
{
	[Token(Token = "0x400A42A")]
	[FieldOffset(Offset = "0x8")]
	public uint basic_mmr;

	[Token(Token = "0x400A42B")]
	[FieldOffset(Offset = "0xC")]
	public uint max_mmr;

	[Token(Token = "0x400A42C")]
	[FieldOffset(Offset = "0x10")]
	public uint result_win;

	[Token(Token = "0x400A42D")]
	[FieldOffset(Offset = "0x14")]
	public float ware_num_rate;

	[Token(Token = "0x400A42E")]
	[FieldOffset(Offset = "0x18")]
	public float kills_rate;

	[Token(Token = "0x6008091")]
	[Address(RVA = "0x309C2F8", Offset = "0x309C2F8", VA = "0x309C2F8")]
	public ClanWarMMRDesc()
	{
	}
}
