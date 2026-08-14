using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200207A")]
public class UICupMatchReviewRewardWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CB9B")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchReviewRewardWndView m_View;

	[Token(Token = "0x400CB9C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB9D")]
	[FieldOffset(Offset = "0x50")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB9E")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CupMatchType;

	[Token(Token = "0x400CB9F")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CupMatchID;

	[Token(Token = "0x400CBA0")]
	[FieldOffset(Offset = "0x5C")]
	private List<GameObject> LeftRewards;

	[Token(Token = "0x400CBA1")]
	[FieldOffset(Offset = "0x60")]
	private List<GameObject> RightRewards;

	[Token(Token = "0x400CBA2")]
	[FieldOffset(Offset = "0x64")]
	private List<GameObject> CenterRewards;

	[Token(Token = "0x400CBA3")]
	[FieldOffset(Offset = "0x68")]
	private CupSettingDesc m_CupSettingDesc;

	[Token(Token = "0x600A6AD")]
	[Address(RVA = "0x2AADAE4", Offset = "0x2AADAE4", VA = "0x2AADAE4")]
	public UICupMatchReviewRewardWndController()
	{
	}

	[Token(Token = "0x600A6AE")]
	[Address(RVA = "0x2AADBA0", Offset = "0x2AADBA0", VA = "0x2AADBA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6AF")]
	[Address(RVA = "0x2AADC48", Offset = "0x2AADC48", VA = "0x2AADC48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6B0")]
	[Address(RVA = "0x2AAE324", Offset = "0x2AAE324", VA = "0x2AAE324")]
	public void SetData(int key)
	{
	}

	[Token(Token = "0x600A6B1")]
	[Address(RVA = "0x2AAE3D8", Offset = "0x2AAE3D8", VA = "0x2AAE3D8")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A6B2")]
	[Address(RVA = "0x2AAF0C4", Offset = "0x2AAF0C4", VA = "0x2AAF0C4")]
	private void RefreshChampionReward(List<GameObject> rewards, bool isTicket)
	{
	}

	[Token(Token = "0x600A6B3")]
	[Address(RVA = "0x2AAF5B8", Offset = "0x2AAF5B8", VA = "0x2AAF5B8")]
	private void OnToggleChange()
	{
	}

	[Token(Token = "0x600A6B4")]
	[Address(RVA = "0x2AAFD8C", Offset = "0x2AAFD8C", VA = "0x2AAFD8C")]
	private void RefreshUseLabel(bool use)
	{
	}

	[Token(Token = "0x600A6B5")]
	[Address(RVA = "0x2AB0328", Offset = "0x2AB0328", VA = "0x2AB0328", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6B6")]
	[Address(RVA = "0x2AB04F4", Offset = "0x2AB04F4", VA = "0x2AB04F4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A6B7")]
	[Address(RVA = "0x2AB0744", Offset = "0x2AB0744", VA = "0x2AB0744", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A6B8")]
	[Address(RVA = "0x2AB07D8", Offset = "0x2AB07D8", VA = "0x2AB07D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A6B9")]
	[Address(RVA = "0x2AB07E0", Offset = "0x2AB07E0", VA = "0x2AB07E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
