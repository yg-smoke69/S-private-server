using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002821")]
public class UIHudRankingGameTips : MonoBehaviour
{
	[Token(Token = "0x400F7B2")]
	[FieldOffset(Offset = "0xC")]
	public UISprite RankIcon;

	[Token(Token = "0x400F7B3")]
	[FieldOffset(Offset = "0x10")]
	public GameObject BRStarContainer;

	[Token(Token = "0x400F7B4")]
	[FieldOffset(Offset = "0x14")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x600FA13")]
	[Address(RVA = "0x1FD8AB8", Offset = "0x1FD8AB8", VA = "0x1FD8AB8")]
	public UIHudRankingGameTips()
	{
	}

	[Token(Token = "0x600FA14")]
	[Address(RVA = "0x1FD8AC0", Offset = "0x1FD8AC0", VA = "0x1FD8AC0")]
	public void UpdateRank(int rank, int score, int peakRankPos)
	{
	}
}
