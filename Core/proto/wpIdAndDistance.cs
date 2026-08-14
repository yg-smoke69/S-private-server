using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001527")]
public class wpIdAndDistance
{
	[Token(Token = "0x40091E5")]
	[FieldOffset(Offset = "0x8")]
	public uint wp_id;

	[Token(Token = "0x40091E6")]
	[FieldOffset(Offset = "0x10")]
	public double distance;

	[Token(Token = "0x40091E7")]
	[FieldOffset(Offset = "0x18")]
	public uint wp_type;

	[Token(Token = "0x6007B70")]
	[Address(RVA = "0x33E6D7C", Offset = "0x33E6D7C", VA = "0x33E6D7C")]
	public wpIdAndDistance()
	{
	}
}
