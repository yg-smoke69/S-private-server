using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A23")]
public class ClanHonorDesc
{
	[Token(Token = "0x400A3CA")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A3CB")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A3CC")]
	[FieldOffset(Offset = "0x10")]
	public double honor;

	[Token(Token = "0x400A3CD")]
	[FieldOffset(Offset = "0x18")]
	public uint upperlimit;

	[Token(Token = "0x400A3CE")]
	[FieldOffset(Offset = "0x1C")]
	public uint division;

	[Token(Token = "0x400A3CF")]
	[FieldOffset(Offset = "0x20")]
	public uint match_mode;

	[Token(Token = "0x400A3D0")]
	[FieldOffset(Offset = "0x24")]
	public uint game_mode;

	[Token(Token = "0x600807B")]
	[Address(RVA = "0x309B858", Offset = "0x309B858", VA = "0x309B858")]
	public ClanHonorDesc()
	{
	}
}
