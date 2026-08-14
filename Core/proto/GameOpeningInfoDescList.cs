using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E3")]
public class GameOpeningInfoDescList
{
	[Token(Token = "0x400A2AB")]
	[FieldOffset(Offset = "0x8")]
	public List<GameOpeningInfoDesc> gameOpeningInfos;

	[Token(Token = "0x600803B")]
	[Address(RVA = "0x30A1BFC", Offset = "0x30A1BFC", VA = "0x30A1BFC")]
	public GameOpeningInfoDescList()
	{
	}
}
