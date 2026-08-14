using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E5")]
public class GameModeNameList
{
	[Token(Token = "0x400A2AF")]
	[FieldOffset(Offset = "0x8")]
	public List<GameModeNameDesc> game_mode_names;

	[Token(Token = "0x600803D")]
	[Address(RVA = "0x30A1A40", Offset = "0x30A1A40", VA = "0x30A1A40")]
	public GameModeNameList()
	{
	}
}
