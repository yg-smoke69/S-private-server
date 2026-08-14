using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200184E")]
public class BooyahgoBoard
{
	[Token(Token = "0x4009CAD")]
	[FieldOffset(Offset = "0x8")]
	public List<BooyahgoNodeDesc> nodes;

	[Token(Token = "0x4009CAE")]
	[FieldOffset(Offset = "0xC")]
	public int skull_king_index;

	[Token(Token = "0x6007EA8")]
	[Address(RVA = "0x317CD3C", Offset = "0x317CD3C", VA = "0x317CD3C")]
	public BooyahgoBoard()
	{
	}
}
