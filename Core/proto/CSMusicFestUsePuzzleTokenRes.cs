using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C6")]
public class CSMusicFestUsePuzzleTokenRes
{
	[Token(Token = "0x4009DD4")]
	[FieldOffset(Offset = "0x8")]
	public List<MusicFestPuzzleDetail> puzzles;

	[Token(Token = "0x6007F1F")]
	[Address(RVA = "0x3098090", Offset = "0x3098090", VA = "0x3098090")]
	public CSMusicFestUsePuzzleTokenRes()
	{
	}
}
