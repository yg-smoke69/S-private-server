using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A22")]
public class ClanExtendScaleDesc
{
	[Token(Token = "0x400A3C7")]
	[FieldOffset(Offset = "0x8")]
	public uint extend_times;

	[Token(Token = "0x400A3C8")]
	[FieldOffset(Offset = "0xC")]
	public uint extend_size;

	[Token(Token = "0x400A3C9")]
	[FieldOffset(Offset = "0x10")]
	public uint diamond_cost;

	[Token(Token = "0x600807A")]
	[Address(RVA = "0x309B850", Offset = "0x309B850", VA = "0x309B850")]
	public ClanExtendScaleDesc()
	{
	}
}
