using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9A")]
public class OppositeSexModelDesc
{
	[Token(Token = "0x400A6B3")]
	[FieldOffset(Offset = "0x8")]
	public uint male_model_id;

	[Token(Token = "0x400A6B4")]
	[FieldOffset(Offset = "0xC")]
	public uint female_model_id;

	[Token(Token = "0x400A6B5")]
	[FieldOffset(Offset = "0x10")]
	public uint start_timestamp;

	[Token(Token = "0x400A6B6")]
	[FieldOffset(Offset = "0x14")]
	public uint end_timestamp;

	[Token(Token = "0x60080F7")]
	[Address(RVA = "0x33DED4C", Offset = "0x33DED4C", VA = "0x33DED4C")]
	public OppositeSexModelDesc()
	{
	}
}
