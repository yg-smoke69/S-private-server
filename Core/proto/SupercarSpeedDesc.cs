using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B56")]
public class SupercarSpeedDesc
{
	[Token(Token = "0x400ABF6")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ABF7")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x400ABF8")]
	[FieldOffset(Offset = "0x10")]
	public uint speed;

	[Token(Token = "0x400ABF9")]
	[FieldOffset(Offset = "0x14")]
	public string icon;

	[Token(Token = "0x400ABFA")]
	[FieldOffset(Offset = "0x18")]
	public uint gopos;

	[Token(Token = "0x400ABFB")]
	[FieldOffset(Offset = "0x1C")]
	public uint sub_gopos;

	[Token(Token = "0x60081B1")]
	[Address(RVA = "0x33E2FF8", Offset = "0x33E2FF8", VA = "0x33E2FF8")]
	public SupercarSpeedDesc()
	{
	}
}
