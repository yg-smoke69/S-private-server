using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200207B")]
public class UICupMatchRewardBoxAnimController : UIBaseController
{
	[Token(Token = "0x400CBA4")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchRewardBoxView m_View;

	[Token(Token = "0x400CBA5")]
	[FieldOffset(Offset = "0x2C")]
	private List<Transform> m_ResultTrans;

	[Token(Token = "0x400CBA6")]
	[FieldOffset(Offset = "0x30")]
	private List<CupMatchRewardBoxResultItem> m_ResultItems;

	[Token(Token = "0x400CBA7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBA8")]
	[FieldOffset(Offset = "0x38")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBA9")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_BoxEffects;

	[Token(Token = "0x600A6BA")]
	[Address(RVA = "0x2AB11A4", Offset = "0x2AB11A4", VA = "0x2AB11A4")]
	public UICupMatchRewardBoxAnimController()
	{
	}

	[Token(Token = "0x600A6BB")]
	[Address(RVA = "0x2AB12C4", Offset = "0x2AB12C4", VA = "0x2AB12C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6BC")]
	[Address(RVA = "0x2AB136C", Offset = "0x2AB136C", VA = "0x2AB136C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6BD")]
	[Address(RVA = "0x2AB1A78", Offset = "0x2AB1A78", VA = "0x2AB1A78", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6BE")]
	[Address(RVA = "0x2AB1BAC", Offset = "0x2AB1BAC", VA = "0x2AB1BAC")]
	public void Init(int key)
	{
	}

	[Token(Token = "0x600A6BF")]
	[Address(RVA = "0x2AB21F4", Offset = "0x2AB21F4", VA = "0x2AB21F4")]
	public void ShowClaimed()
	{
	}

	[Token(Token = "0x600A6C0")]
	[Address(RVA = "0x2AB1E80", Offset = "0x2AB1E80", VA = "0x2AB1E80")]
	private void RefreshBox()
	{
	}

	[Token(Token = "0x600A6C1")]
	[Address(RVA = "0x2AB179C", Offset = "0x2AB179C", VA = "0x2AB179C")]
	private void CreateResultItem()
	{
	}

	[Token(Token = "0x600A6C2")]
	[Address(RVA = "0x2AB1C20", Offset = "0x2AB1C20", VA = "0x2AB1C20")]
	private void UpdateResultItem()
	{
	}

	[Token(Token = "0x600A6C3")]
	[Address(RVA = "0x2AB2314", Offset = "0x2AB2314", VA = "0x2AB2314")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A6C4")]
	[Address(RVA = "0x2AB2284", Offset = "0x2AB2284", VA = "0x2AB2284")]
	private bool NeedUpdateBox()
	{
		return default(bool);
	}

	[Token(Token = "0x600A6C5")]
	[Address(RVA = "0x2AB2800", Offset = "0x2AB2800", VA = "0x2AB2800")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A6C6")]
	[Address(RVA = "0x2AB2808", Offset = "0x2AB2808", VA = "0x2AB2808")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
