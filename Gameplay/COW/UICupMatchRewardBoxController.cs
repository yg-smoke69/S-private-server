using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200207C")]
public class UICupMatchRewardBoxController : UIBaseController, _Attribute
{
	[Token(Token = "0x400CBAA")]
	[FieldOffset(Offset = "0x28")]
	private UICupMatchRewardBoxView m_View;

	[Token(Token = "0x400CBAB")]
	[FieldOffset(Offset = "0x2C")]
	private List<Transform> m_ResultTrans;

	[Token(Token = "0x400CBAC")]
	[FieldOffset(Offset = "0x30")]
	private List<CupMatchRewardBoxResultItem> m_ResultItems;

	[Token(Token = "0x400CBAD")]
	[FieldOffset(Offset = "0x34")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBAE")]
	[FieldOffset(Offset = "0x38")]
	private uint m_CupMatchType;

	[Token(Token = "0x400CBAF")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_CupMatchID;

	[Token(Token = "0x400CBB0")]
	[FieldOffset(Offset = "0x40")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBB1")]
	[FieldOffset(Offset = "0x44")]
	private CupChestDesc m_CacheReward;

	[Token(Token = "0x400CBB2")]
	[FieldOffset(Offset = "0x48")]
	private bool m_CanShowReward;

	[Token(Token = "0x400CBB3")]
	[FieldOffset(Offset = "0x4C")]
	private List<GameObject> m_BoxEffects;

	[Token(Token = "0x600A6C7")]
	[Address(RVA = "0x2AB2810", Offset = "0x2AB2810", VA = "0x2AB2810")]
	public UICupMatchRewardBoxController()
	{
	}

	[Token(Token = "0x600A6C8")]
	[Address(RVA = "0x2AB2930", Offset = "0x2AB2930", VA = "0x2AB2930")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6C9")]
	[Address(RVA = "0x2AB29D8", Offset = "0x2AB29D8", VA = "0x2AB29D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A6CA")]
	[Address(RVA = "0x2AB30A4", Offset = "0x2AB30A4", VA = "0x2AB30A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6CB")]
	[Address(RVA = "0x2AB312C", Offset = "0x2AB312C", VA = "0x2AB312C")]
	public void Init(int key, bool top, bool showReward = true)
	{
	}

	[Token(Token = "0x600A6CC")]
	[Address(RVA = "0x2AB34D8", Offset = "0x2AB34D8", VA = "0x2AB34D8")]
	public void RefreshBox()
	{
	}

	[Token(Token = "0x600A6CD")]
	[Address(RVA = "0x2AB37C8", Offset = "0x2AB37C8", VA = "0x2AB37C8")]
	private void RefreshBoxState()
	{
	}

	[Token(Token = "0x600A6CE")]
	[Address(RVA = "0x2AB2DC8", Offset = "0x2AB2DC8", VA = "0x2AB2DC8")]
	private void CreateResultItem()
	{
	}

	[Token(Token = "0x600A6CF")]
	[Address(RVA = "0x2AB3278", Offset = "0x2AB3278", VA = "0x2AB3278")]
	private void UpdateResultItem()
	{
	}

	[Token(Token = "0x600A6D0")]
	[Address(RVA = "0x2AB3944", Offset = "0x2AB3944", VA = "0x2AB3944")]
	private void OnRewardClick()
	{
	}

	[Token(Token = "0x600A6D1")]
	[Address(RVA = "0x2AB3C00", Offset = "0x2AB3C00", VA = "0x2AB3C00", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A6D2")]
	[Address(RVA = "0x2AB3DD8", Offset = "0x2AB3DD8", VA = "0x2AB3DD8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A6D3")]
	[Address(RVA = "0x2AB3E6C", Offset = "0x2AB3E6C", VA = "0x2AB3E6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A6D4")]
	[Address(RVA = "0x2AB3E74", Offset = "0x2AB3E74", VA = "0x2AB3E74")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
