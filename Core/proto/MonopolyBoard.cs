using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001845")]
public class MonopolyBoard
{
	[Token(Token = "0x4009C92")]
	[FieldOffset(Offset = "0x8")]
	public List<MonopolyNodeDesc> nodes;

	[Token(Token = "0x6007E9F")]
	[Address(RVA = "0x30A8E4C", Offset = "0x30A8E4C", VA = "0x30A8E4C")]
	public MonopolyBoard()
	{
	}
}
