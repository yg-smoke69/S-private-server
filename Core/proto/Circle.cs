using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200183C")]
public class Circle
{
	[Token(Token = "0x4009C6A")]
	[FieldOffset(Offset = "0x8")]
	public Point center;

	[Token(Token = "0x4009C6B")]
	[FieldOffset(Offset = "0x10")]
	public double radius;

	[Token(Token = "0x6007E96")]
	[Address(RVA = "0x309B820", Offset = "0x309B820", VA = "0x309B820")]
	public Circle()
	{
	}
}
