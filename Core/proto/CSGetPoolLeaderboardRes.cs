using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018A4")]
public class CSGetPoolLeaderboardRes
{
	[Token(Token = "0x4009D74")]
	[FieldOffset(Offset = "0x8")]
	public List<PoolLeaderboardPlayerInfo> players_info;

	[Token(Token = "0x6007EFD")]
	[Address(RVA = "0x30949B8", Offset = "0x30949B8", VA = "0x30949B8")]
	public CSGetPoolLeaderboardRes()
	{
	}
}
