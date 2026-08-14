using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6F")]
public class BooyahChessZoneDesc
{
	[Token(Token = "0x400AC8D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC8E")]
	[FieldOffset(Offset = "0xC")]
	public uint step;

	[Token(Token = "0x400AC8F")]
	[FieldOffset(Offset = "0x10")]
	public bool booyah;

	[Token(Token = "0x400AC90")]
	[FieldOffset(Offset = "0x18")]
	public double radius;

	[Token(Token = "0x60081CA")]
	[Address(RVA = "0x317C974", Offset = "0x317C974", VA = "0x317C974")]
	public BooyahChessZoneDesc()
	{
	}
}
