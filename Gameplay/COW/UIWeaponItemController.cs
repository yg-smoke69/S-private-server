using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200214E")]
public class UIWeaponItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x200214F")]
	public class ViewState
	{
		[Token(Token = "0x400D130")]
		[FieldOffset(Offset = "0x8")]
		public bool m_Selected;

		[Token(Token = "0x600AFC8")]
		[Address(RVA = "0x101EF40", Offset = "0x101EF40", VA = "0x101EF40")]
		public ViewState()
		{
		}
	}

	[Token(Token = "0x400D124")]
	[FieldOffset(Offset = "0x28")]
	private int m_tableIndex;

	[Token(Token = "0x400D125")]
	[FieldOffset(Offset = "0x2C")]
	private UIWeaponItemView m_View;

	[Token(Token = "0x400D126")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D127")]
	[FieldOffset(Offset = "0x34")]
	private CollectionBaseInfo m_CollectionInfo;

	[Token(Token = "0x400D128")]
	[FieldOffset(Offset = "0x38")]
	private uint m_ItemID;

	[Token(Token = "0x400D129")]
	[FieldOffset(Offset = "0x3C")]
	private object m_Data;

	[Token(Token = "0x400D12A")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CollectionABReady;

	[Token(Token = "0x400D12B")]
	[FieldOffset(Offset = "0x44")]
	private int[] m_DefaultWeaponSize;

	[Token(Token = "0x400D12C")]
	[FieldOffset(Offset = "0x48")]
	private int[] m_DefaultVehicleSize;

	[Token(Token = "0x400D12D")]
	[FieldOffset(Offset = "0x4C")]
	public Action<int> OnSelectCallback;

	[Token(Token = "0x400D12E")]
	[FieldOffset(Offset = "0x50")]
	private ViewState m_ViewState;

	[Token(Token = "0x400D12F")]
	[FieldOffset(Offset = "0x54")]
	private uint m_ItemIconGrey;

	[Token(Token = "0x600AFB9")]
	[Address(RVA = "0x101CCBC", Offset = "0x101CCBC", VA = "0x101CCBC")]
	public UIWeaponItemController()
	{
	}

	[Token(Token = "0x600AFBA")]
	[Address(RVA = "0x101CD4C", Offset = "0x101CD4C", VA = "0x101CD4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AFBB")]
	[Address(RVA = "0x101CDF4", Offset = "0x101CDF4", VA = "0x101CDF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AFBC")]
	[Address(RVA = "0x101D3A4", Offset = "0x101D3A4", VA = "0x101D3A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AFBD")]
	[Address(RVA = "0x101D4D8", Offset = "0x101D4D8", VA = "0x101D4D8")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600AFBE")]
	[Address(RVA = "0x101D740", Offset = "0x101D740", VA = "0x101D740")]
	public void SelectItem(bool select)
	{
	}

	[Token(Token = "0x600AFBF")]
	[Address(RVA = "0x101D7C4", Offset = "0x101D7C4", VA = "0x101D7C4")]
	private void EffectSelect(bool select)
	{
	}

	[Token(Token = "0x600AFC0")]
	[Address(RVA = "0x101D85C", Offset = "0x101D85C", VA = "0x101D85C")]
	public void HighLightCurrent()
	{
	}

	[Token(Token = "0x600AFC1")]
	[Address(RVA = "0x101DBBC", Offset = "0x101DBBC", VA = "0x101DBBC", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600AFC2")]
	[Address(RVA = "0x101F214", Offset = "0x101F214", VA = "0x101F214")]
	private void OnItemUpdate(object[] param)
	{
	}

	[Token(Token = "0x600AFC3")]
	[Address(RVA = "0x101EF48", Offset = "0x101EF48", VA = "0x101EF48")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x600AFC4")]
	[Address(RVA = "0x101F27C", Offset = "0x101F27C", VA = "0x101F27C", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600AFC5")]
	[Address(RVA = "0x101F3A4", Offset = "0x101F3A4", VA = "0x101F3A4", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600AFC6")]
	[Address(RVA = "0x101F434", Offset = "0x101F434", VA = "0x101F434")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AFC7")]
	[Address(RVA = "0x101F43C", Offset = "0x101F43C", VA = "0x101F43C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
