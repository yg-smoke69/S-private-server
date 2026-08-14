using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002261")]
public class UILadderAnimationParam : MonoBehaviour
{
	[Token(Token = "0x400D704")]
	[FieldOffset(Offset = "0xC")]
	private UISprite m_BRRankIconBefore;

	[Token(Token = "0x400D705")]
	[FieldOffset(Offset = "0x10")]
	private UISprite m_BRRankIconAfter;

	[Token(Token = "0x400D706")]
	[FieldOffset(Offset = "0x14")]
	private UISprite m_CSRankIconBefore;

	[Token(Token = "0x400D707")]
	[FieldOffset(Offset = "0x18")]
	private UISprite m_CSRankIconAfter;

	[Token(Token = "0x400D708")]
	[FieldOffset(Offset = "0x1C")]
	private UILabel m_RankLabelBefore;

	[Token(Token = "0x400D709")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_RankLabelAfter;

	[Token(Token = "0x600BBCC")]
	[Address(RVA = "0x1AE4E10", Offset = "0x1AE4E10", VA = "0x1AE4E10")]
	public UILadderAnimationParam()
	{
	}

	[Token(Token = "0x600BBCD")]
	[Address(RVA = "0x1AE4E18", Offset = "0x1AE4E18", VA = "0x1AE4E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BBCE")]
	[Address(RVA = "0x1AE55E4", Offset = "0x1AE55E4", VA = "0x1AE55E4")]
	public void SetLabelAndIcon(string beforeRankName, string afterRankName, ResourceID beforeRankIcon, ResourceID afterRankIcon, bool isBR = true)
	{
	}

	[Token(Token = "0x600BBCF")]
	[Address(RVA = "0x1AE583C", Offset = "0x1AE583C", VA = "0x1AE583C")]
	private void SetVisiableState(bool isBR)
	{
	}
}
