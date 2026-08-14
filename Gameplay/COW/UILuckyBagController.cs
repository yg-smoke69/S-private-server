using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002957")]
public class UILuckyBagController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002958")]
	private struct ProgressChangeData
	{
		[Token(Token = "0x400FED8")]
		[FieldOffset(Offset = "0x0")]
		public bool isDouble;

		[Token(Token = "0x400FED9")]
		[FieldOffset(Offset = "0x4")]
		public uint initScore;

		[Token(Token = "0x400FEDA")]
		[FieldOffset(Offset = "0x8")]
		public uint targetScore;

		[Token(Token = "0x400FEDB")]
		[FieldOffset(Offset = "0xC")]
		public uint nextLevelScore;
	}

	[Token(Token = "0x2002959")]
	private sealed class _003CShowTrailVFX_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FEDC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong bagId;

		[Token(Token = "0x60108D2")]
		[Address(RVA = "0x21FF1C4", Offset = "0x21FF1C4", VA = "0x21FF1C4")]
		public _003CShowTrailVFX_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60108D3")]
		[Address(RVA = "0x2200F54", Offset = "0x2200F54", VA = "0x2200F54")]
		internal bool _003C_003Em__0(ClanLuckyBag item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FECD")]
	[FieldOffset(Offset = "0x48")]
	private UILuckyBagView m_View;

	[Token(Token = "0x400FECE")]
	[FieldOffset(Offset = "0x4C")]
	private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

	[Token(Token = "0x400FECF")]
	[FieldOffset(Offset = "0x50")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400FED0")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_SelectedBagID;

	[Token(Token = "0x400FED1")]
	[FieldOffset(Offset = "0x60")]
	private bool m_ProgressChanged;

	[Token(Token = "0x400FED2")]
	[FieldOffset(Offset = "0x64")]
	private uint m_TargetScore;

	[Token(Token = "0x400FED3")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurrentScore;

	[Token(Token = "0x400FED4")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_InitScore;

	[Token(Token = "0x400FED5")]
	[FieldOffset(Offset = "0x70")]
	private uint m_NextLevelScore;

	[Token(Token = "0x400FED6")]
	[FieldOffset(Offset = "0x74")]
	private uint m_RefreshBoxVFXDelayCall;

	[Token(Token = "0x400FED7")]
	[FieldOffset(Offset = "0x78")]
	private Queue<ProgressChangeData> m_VFXProgressChangedQueue;

	[Token(Token = "0x60108AD")]
	[Address(RVA = "0x21FC24C", Offset = "0x21FC24C", VA = "0x21FC24C")]
	public UILuckyBagController()
	{
	}

	[Token(Token = "0x60108AE")]
	[Address(RVA = "0x21FC2D8", Offset = "0x21FC2D8", VA = "0x21FC2D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60108AF")]
	[Address(RVA = "0x21FC380", Offset = "0x21FC380", VA = "0x21FC380", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x60108B0")]
	[Address(RVA = "0x21FC424", Offset = "0x21FC424", VA = "0x21FC424", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60108B1")]
	[Address(RVA = "0x21FCB18", Offset = "0x21FCB18", VA = "0x21FCB18")]
	private void InitVFX()
	{
	}

	[Token(Token = "0x60108B2")]
	[Address(RVA = "0x21FD0E8", Offset = "0x21FD0E8", VA = "0x21FD0E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60108B3")]
	[Address(RVA = "0x21FD240", Offset = "0x21FD240", VA = "0x21FD240")]
	private void LinearChangeNumber(float initNum, float showNum, float targetNum, float duration)
	{
	}

	[Token(Token = "0x60108B4")]
	[Address(RVA = "0x21FD4CC", Offset = "0x21FD4CC", VA = "0x21FD4CC")]
	private void RefreshViewData(bool updateProgressBarImmediatly = true)
	{
	}

	[Token(Token = "0x60108B5")]
	[Address(RVA = "0x21FCD38", Offset = "0x21FCD38", VA = "0x21FCD38")]
	private void InitAwardBigContainer()
	{
	}

	[Token(Token = "0x60108B6")]
	[Address(RVA = "0x21FD934", Offset = "0x21FD934", VA = "0x21FD934")]
	private void RefreshBigLuckyBag(bool updateProgressBarImmediatly = true)
	{
	}

	[Token(Token = "0x60108B7")]
	[Address(RVA = "0x21FE27C", Offset = "0x21FE27C", VA = "0x21FE27C")]
	private string GetLevelSpriteNameByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x60108B8")]
	[Address(RVA = "0x21FE394", Offset = "0x21FE394", VA = "0x21FE394")]
	private void HighlightCurrent()
	{
	}

	[Token(Token = "0x60108B9")]
	[Address(RVA = "0x21FE5F8", Offset = "0x21FE5F8", VA = "0x21FE5F8")]
	private void OnLuckyBagDrawed(object[] data)
	{
	}

	[Token(Token = "0x60108BA")]
	[Address(RVA = "0x21FE6C8", Offset = "0x21FE6C8", VA = "0x21FE6C8")]
	private void OnLuckyBagProgressChanged(object[] data)
	{
	}

	[Token(Token = "0x60108BB")]
	[Address(RVA = "0x21FEC10", Offset = "0x21FEC10", VA = "0x21FEC10")]
	private void ShowTrailVFX(ulong bagId, ProgressChangeData pData)
	{
	}

	[Token(Token = "0x60108BC")]
	[Address(RVA = "0x21FF418", Offset = "0x21FF418", VA = "0x21FF418")]
	private void OnTrailVFXEnd(object[] data)
	{
	}

	[Token(Token = "0x60108BD")]
	[Address(RVA = "0x21FD660", Offset = "0x21FD660", VA = "0x21FD660")]
	private void RefreshScrollViewData()
	{
	}

	[Token(Token = "0x60108BE")]
	[Address(RVA = "0x21FF640", Offset = "0x21FF640", VA = "0x21FF640")]
	private void OnBigLuckyBagAwardClaimed(object[] data)
	{
	}

	[Token(Token = "0x60108BF")]
	[Address(RVA = "0x21FF8F4", Offset = "0x21FF8F4", VA = "0x21FF8F4")]
	private void LuckyBagClaimedAll(object[] data)
	{
	}

	[Token(Token = "0x60108C0")]
	[Address(RVA = "0x21FFE60", Offset = "0x21FFE60", VA = "0x21FFE60", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60108C1")]
	[Address(RVA = "0x21FFEC4", Offset = "0x21FFEC4", VA = "0x21FFEC4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60108C2")]
	[Address(RVA = "0x220004C", Offset = "0x220004C", VA = "0x220004C")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x60108C3")]
	[Address(RVA = "0x22000A0", Offset = "0x22000A0", VA = "0x22000A0")]
	private void OnTestLuckyBagClick()
	{
	}

	[Token(Token = "0x60108C4")]
	[Address(RVA = "0x22002A4", Offset = "0x22002A4", VA = "0x22002A4")]
	private void OnAwardBtnClick()
	{
	}

	[Token(Token = "0x60108C5")]
	[Address(RVA = "0x21FD58C", Offset = "0x21FD58C", VA = "0x21FD58C")]
	private void ShowClaimAllBtn()
	{
	}

	[Token(Token = "0x60108C6")]
	[Address(RVA = "0x22003B4", Offset = "0x22003B4", VA = "0x22003B4")]
	private void OnClaimAllBtnClick()
	{
	}

	[Token(Token = "0x60108C7")]
	[Address(RVA = "0x22004C8", Offset = "0x22004C8", VA = "0x22004C8")]
	private void OnReceiveBtnClick()
	{
	}

	[Token(Token = "0x60108C8")]
	[Address(RVA = "0x2200980", Offset = "0x2200980", VA = "0x2200980", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60108C9")]
	[Address(RVA = "0x2200A78", Offset = "0x2200A78", VA = "0x2200A78", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60108CA")]
	[Address(RVA = "0x2200AF4", Offset = "0x2200AF4", VA = "0x2200AF4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60108CB")]
	[Address(RVA = "0x2200E2C", Offset = "0x2200E2C", VA = "0x2200E2C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60108CC")]
	[Address(RVA = "0x2200E90", Offset = "0x2200E90", VA = "0x2200E90")]
	private bool _003CHighlightCurrent_003Em__0(ClanLuckyBag item)
	{
		return default(bool);
	}

	[Token(Token = "0x60108CD")]
	[Address(RVA = "0x2200ED0", Offset = "0x2200ED0", VA = "0x2200ED0")]
	private void _003COnBigLuckyBagAwardClaimed_003Em__1()
	{
	}

	[Token(Token = "0x60108CE")]
	[Address(RVA = "0x2200F34", Offset = "0x2200F34", VA = "0x2200F34")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x60108CF")]
	[Address(RVA = "0x2200F3C", Offset = "0x2200F3C", VA = "0x2200F3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60108D0")]
	[Address(RVA = "0x2200F44", Offset = "0x2200F44", VA = "0x2200F44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60108D1")]
	[Address(RVA = "0x2200F4C", Offset = "0x2200F4C", VA = "0x2200F4C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
