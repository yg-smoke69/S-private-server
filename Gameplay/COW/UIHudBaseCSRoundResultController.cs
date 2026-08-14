using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200203B")]
internal class UIHudBaseCSRoundResultController : UIBaseController
{
	[Token(Token = "0x400CA22")]
	[FieldOffset(Offset = "0x28")]
	protected UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CA23")]
	[FieldOffset(Offset = "0x2C")]
	protected List<GameObject> m_BonusItemList;

	[Token(Token = "0x400CA24")]
	[FieldOffset(Offset = "0x30")]
	protected GameObject bonusItem;

	[Token(Token = "0x400CA25")]
	[FieldOffset(Offset = "0x34")]
	protected UIGrid bonusGrid;

	[Token(Token = "0x400CA26")]
	[FieldOffset(Offset = "0x38")]
	protected UILabel LabelReason;

	[Token(Token = "0x600A3A8")]
	[Address(RVA = "0x1DF930C", Offset = "0x1DF930C", VA = "0x1DF930C")]
	public UIHudBaseCSRoundResultController()
	{
	}

	[Token(Token = "0x600A3A9")]
	[Address(RVA = "0x1DF93C4", Offset = "0x1DF93C4", VA = "0x1DF93C4")]
	public void SetBonusDetailsView(DMJPAJFMMMB res)
	{
	}

	[Token(Token = "0x600A3AA")]
	[Address(RVA = "0x1DF99CC", Offset = "0x1DF99CC", VA = "0x1DF99CC")]
	protected string GetDescriptionOfBonusType(IKFOMLELBPG bonusType, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600A3AB")]
	[Address(RVA = "0x1DF9F14", Offset = "0x1DF9F14", VA = "0x1DF9F14")]
	public void SetRoundWinLoseReason(byte winReason)
	{
	}
}
