using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C4")]
public class CSGetMusicFestInfoRes
{
	[Token(Token = "0x4009DCF")]
	[FieldOffset(Offset = "0x8")]
	public List<MusicFestPuzzleDetail> puzzles;

	[Token(Token = "0x4009DD0")]
	[FieldOffset(Offset = "0xC")]
	public List<MusicFestTradeRecord> unreceived_tokens;

	[Token(Token = "0x4009DD1")]
	[FieldOffset(Offset = "0x10")]
	public MusicFestRewardsInfo rewards_info;

	[Token(Token = "0x4009DD2")]
	[FieldOffset(Offset = "0x14")]
	public uint send_cnt;

	[Token(Token = "0x6007F1D")]
	[Address(RVA = "0x3187AA4", Offset = "0x3187AA4", VA = "0x3187AA4")]
	public CSGetMusicFestInfoRes()
	{
	}
}
