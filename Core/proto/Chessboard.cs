using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001840")]
public class Chessboard
{
	[Token(Token = "0x4009C80")]
	[FieldOffset(Offset = "0x8")]
	public List<Hexagon> hexagons;

	[Token(Token = "0x6007E9A")]
	[Address(RVA = "0x309B3AC", Offset = "0x309B3AC", VA = "0x309B3AC")]
	public Chessboard()
	{
	}
}
