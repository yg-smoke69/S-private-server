using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200183D")]
public class Hexagon
{
	[Token(Token = "0x4009C6C")]
	[FieldOffset(Offset = "0x8")]
	public Point center;

	[Token(Token = "0x4009C6D")]
	[FieldOffset(Offset = "0x10")]
	public double radius;

	[Token(Token = "0x4009C6E")]
	[FieldOffset(Offset = "0x18")]
	public uint index;

	[Token(Token = "0x4009C6F")]
	[FieldOffset(Offset = "0x1C")]
	public EMiniGame.HexagonStatus status;

	[Token(Token = "0x6007E97")]
	[Address(RVA = "0x30A2FBC", Offset = "0x30A2FBC", VA = "0x30A2FBC")]
	public Hexagon()
	{
	}
}
