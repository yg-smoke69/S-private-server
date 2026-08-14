using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002231")]
public class LadderMatchStarGroup : MonoBehaviour
{
	[Token(Token = "0x400D551")]
	public const string ANIMATION_LABEL_CHANGE = "UILadderCSMatchLabelStarChange";

	[Token(Token = "0x400D552")]
	[FieldOffset(Offset = "0xC")]
	private List<LadderMatchStar> starsList;

	[Token(Token = "0x400D553")]
	[FieldOffset(Offset = "0x10")]
	private uint currentOnCnt;

	[Token(Token = "0x400D554")]
	[FieldOffset(Offset = "0x14")]
	private uint starCnt;

	[Token(Token = "0x400D555")]
	[FieldOffset(Offset = "0x18")]
	private Transform m_starRoot;

	[Token(Token = "0x400D556")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject m_starRes;

	[Token(Token = "0x400D557")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_starLabel;

	[Token(Token = "0x400D558")]
	[FieldOffset(Offset = "0x24")]
	private UILabel m_starLabelAfter;

	[Token(Token = "0x400D559")]
	[FieldOffset(Offset = "0x28")]
	private Animation m_labelAnim;

	[Token(Token = "0x400D55A")]
	[FieldOffset(Offset = "0x2C")]
	private bool isStarRank;

	[Token(Token = "0x600B95F")]
	[Address(RVA = "0x1EF6270", Offset = "0x1EF6270", VA = "0x1EF6270")]
	public LadderMatchStarGroup(Transform startRoot, GameObject starRes, UILabel rankLabel, UILabel rankLabel_after, Animation labelAnimation)
	{
	}

	[Token(Token = "0x600B960")]
	[Address(RVA = "0x1EF6328", Offset = "0x1EF6328", VA = "0x1EF6328")]
	public void InitMatchStarGroup(uint starCont)
	{
	}

	[Token(Token = "0x600B961")]
	[Address(RVA = "0x1EF6544", Offset = "0x1EF6544", VA = "0x1EF6544")]
	public void InitMatchRankLabel()
	{
	}

	[Token(Token = "0x600B962")]
	[Address(RVA = "0x1EF639C", Offset = "0x1EF639C", VA = "0x1EF639C")]
	private void CreateStar(uint starCount)
	{
	}

	[Token(Token = "0x600B963")]
	[Address(RVA = "0x1EF65A0", Offset = "0x1EF65A0", VA = "0x1EF65A0")]
	public void InitStarsState(uint starOnCnt)
	{
	}

	[Token(Token = "0x600B964")]
	[Address(RVA = "0x1EF6710", Offset = "0x1EF6710", VA = "0x1EF6710")]
	public void ChangeStars(bool isUp)
	{
	}

	[Token(Token = "0x600B965")]
	[Address(RVA = "0x1EF6784", Offset = "0x1EF6784", VA = "0x1EF6784")]
	public void ChangeLabelStars(bool isUp)
	{
	}

	[Token(Token = "0x600B966")]
	[Address(RVA = "0x1EF68C8", Offset = "0x1EF68C8", VA = "0x1EF68C8")]
	public void SetLabelStarsState(bool isUp = true)
	{
	}

	[Token(Token = "0x600B967")]
	[Address(RVA = "0x1EF6A14", Offset = "0x1EF6A14", VA = "0x1EF6A14")]
	public LadderMatchStar GetNeedGainStar()
	{
		return null;
	}

	[Token(Token = "0x600B968")]
	[Address(RVA = "0x1EF6B30", Offset = "0x1EF6B30", VA = "0x1EF6B30")]
	public LadderMatchStar GetNeedLoseStar()
	{
		return null;
	}

	[Token(Token = "0x600B969")]
	[Address(RVA = "0x1EF6C50", Offset = "0x1EF6C50", VA = "0x1EF6C50")]
	public Animation GetLabelAnimation()
	{
		return null;
	}
}
