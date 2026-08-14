using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000711")]
public class PVEHyakkiMatchDifficultyRelatedConfig
{
	[Token(Token = "0x4004C09")]
	[FieldOffset(Offset = "0x8")]
	public int Difficulty;

	[Token(Token = "0x4004C0A")]
	[FieldOffset(Offset = "0xC")]
	public int RoundCount;

	[Token(Token = "0x4004C0B")]
	[FieldOffset(Offset = "0x10")]
	public int GameTotalTime_S;

	[Token(Token = "0x4004C0C")]
	[FieldOffset(Offset = "0x14")]
	public List<RoundInfo> RoundInfos;

	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x1C79218", Offset = "0x1C79218", VA = "0x1C79218")]
	public PVEHyakkiMatchDifficultyRelatedConfig()
	{
	}
}
