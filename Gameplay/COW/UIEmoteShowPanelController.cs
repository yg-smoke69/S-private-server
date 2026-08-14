using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002603")]
public class UIEmoteShowPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002604")]
	private sealed class _003COnEmoteItemClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EAD5")]
		[FieldOffset(Offset = "0x8")]
		internal ulong localAccountId;

		[Token(Token = "0x600E0C3")]
		[Address(RVA = "0x19D5838", Offset = "0x19D5838", VA = "0x19D5838")]
		public _003COnEmoteItemClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E0C4")]
		[Address(RVA = "0x19D59E4", Offset = "0x19D59E4", VA = "0x19D59E4")]
		internal bool _003C_003Em__0(AccountEmoteRandomID e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EAD1")]
	[FieldOffset(Offset = "0x28")]
	private UIEmoteShowPanelView m_View;

	[Token(Token = "0x400EAD2")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIEmoteShowItemView> m_EmoteItems;

	[Token(Token = "0x400EAD3")]
	[FieldOffset(Offset = "0x30")]
	private List<Transform> m_UIDressUpDesgarPos;

	[Token(Token = "0x400EAD4")]
	[FieldOffset(Offset = "0x34")]
	private UIModelOptionalDownload m_ModelOptionalDownload;

	[Token(Token = "0x600E0B3")]
	[Address(RVA = "0x19D32C8", Offset = "0x19D32C8", VA = "0x19D32C8")]
	public UIEmoteShowPanelController()
	{
	}

	[Token(Token = "0x600E0B4")]
	[Address(RVA = "0x19D3424", Offset = "0x19D3424", VA = "0x19D3424")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0B5")]
	[Address(RVA = "0x19D34CC", Offset = "0x19D34CC", VA = "0x19D34CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0B6")]
	[Address(RVA = "0x19D42C4", Offset = "0x19D42C4", VA = "0x19D42C4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E0B7")]
	[Address(RVA = "0x19D43F8", Offset = "0x19D43F8", VA = "0x19D43F8")]
	public void SetPanelDepth(int depth)
	{
	}

	[Token(Token = "0x600E0B8")]
	[Address(RVA = "0x19D4534", Offset = "0x19D4534", VA = "0x19D4534")]
	public void UpdateEmoteItemDownloadStatus(uint eID, uint slotID, UIEmoteShowItemView item)
	{
	}

	[Token(Token = "0x600E0B9")]
	[Address(RVA = "0x19D3A98", Offset = "0x19D3A98", VA = "0x19D3A98")]
	private void UpdateEmotions()
	{
	}

	[Token(Token = "0x600E0BA")]
	[Address(RVA = "0x19D3D48", Offset = "0x19D3D48", VA = "0x19D3D48")]
	private void InitDressups()
	{
	}

	[Token(Token = "0x600E0BB")]
	[Address(RVA = "0x19D4998", Offset = "0x19D4998", VA = "0x19D4998")]
	private void OnClickMask()
	{
	}

	[Token(Token = "0x600E0BC")]
	[Address(RVA = "0x19D4214", Offset = "0x19D4214", VA = "0x19D4214")]
	private void RefreshBtnCustomoAnimVisibility()
	{
	}

	[Token(Token = "0x600E0BD")]
	[Address(RVA = "0x19D4AA4", Offset = "0x19D4AA4", VA = "0x19D4AA4")]
	protected void OnBtnCustomAnimClick()
	{
	}

	[Token(Token = "0x600E0BE")]
	[Address(RVA = "0x19D4BE0", Offset = "0x19D4BE0", VA = "0x19D4BE0")]
	private void OnEmoteItemClick(object[] data)
	{
	}

	[Token(Token = "0x600E0BF")]
	[Address(RVA = "0x19D5840", Offset = "0x19D5840", VA = "0x19D5840", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E0C0")]
	[Address(RVA = "0x19D5940", Offset = "0x19D5940", VA = "0x19D5940", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E0C1")]
	[Address(RVA = "0x19D59D4", Offset = "0x19D59D4", VA = "0x19D59D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E0C2")]
	[Address(RVA = "0x19D59DC", Offset = "0x19D59DC", VA = "0x19D59DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
