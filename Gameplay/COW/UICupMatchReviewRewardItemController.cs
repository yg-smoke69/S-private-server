using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002078")]
public class UICupMatchReviewRewardItemController : UIBaseController
{
	[Token(Token = "0x400CB8C")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchReviewRewardItemView m_View;

	[Token(Token = "0x400CB8D")]
	[FieldOffset(Offset = "0x2C")]
	private CupChestDesc m_AwardData;

	[Token(Token = "0x400CB8E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsLeft;

	[Token(Token = "0x400CB8F")]
	[FieldOffset(Offset = "0x34")]
	private List<GameObject> LevelList;

	[Token(Token = "0x400CB90")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> LeftRewardList;

	[Token(Token = "0x400CB91")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> RightRewardList;

	[Token(Token = "0x400CB92")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB93")]
	[FieldOffset(Offset = "0x44")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB94")]
	[FieldOffset(Offset = "0x48")]
	private Color m_BGColor;

	[Token(Token = "0x600A69A")]
	[Address(RVA = "0x2AAA8D8", Offset = "0x2AAA8D8", VA = "0x2AAA8D8")]
	public UICupMatchReviewRewardItemController()
	{
	}

	[Token(Token = "0x600A69B")]
	[Address(RVA = "0x2AAA9C0", Offset = "0x2AAA9C0", VA = "0x2AAA9C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A69C")]
	[Address(RVA = "0x2AAAA68", Offset = "0x2AAAA68", VA = "0x2AAAA68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A69D")]
	[Address(RVA = "0x2AAAFAC", Offset = "0x2AAAFAC", VA = "0x2AAAFAC")]
	public void SetData(CupChestDesc data, bool isLeft, int key)
	{
	}

	[Token(Token = "0x600A69E")]
	[Address(RVA = "0x2AAB03C", Offset = "0x2AAB03C", VA = "0x2AAB03C")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A69F")]
	[Address(RVA = "0x2AAB4C8", Offset = "0x2AAB4C8", VA = "0x2AAB4C8")]
	private void RefreshRewardList()
	{
	}

	[Token(Token = "0x600A6A0")]
	[Address(RVA = "0x2AAB984", Offset = "0x2AAB984", VA = "0x2AAB984")]
	private void UpdateBGColor()
	{
	}

	[Token(Token = "0x600A6A1")]
	[Address(RVA = "0x2AABABC", Offset = "0x2AABABC", VA = "0x2AABABC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
