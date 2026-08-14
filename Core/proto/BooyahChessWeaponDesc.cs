using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B71")]
public class BooyahChessWeaponDesc
{
	[Token(Token = "0x400AC9D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC9E")]
	[FieldOffset(Offset = "0xC")]
	public string desc;

	[Token(Token = "0x400AC9F")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400ACA0")]
	[FieldOffset(Offset = "0x14")]
	public string icon;

	[Token(Token = "0x400ACA1")]
	[FieldOffset(Offset = "0x18")]
	public uint weight;

	[Token(Token = "0x60081CC")]
	[Address(RVA = "0x317C8BC", Offset = "0x317C8BC", VA = "0x317C8BC")]
	public BooyahChessWeaponDesc()
	{
	}
}
