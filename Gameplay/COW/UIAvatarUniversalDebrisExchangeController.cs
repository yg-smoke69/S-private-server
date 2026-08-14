using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024DD")]
public class UIAvatarUniversalDebrisExchangeController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x20024DE")]
	private sealed class _003CInitView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E492")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x400E493")]
		[FieldOffset(Offset = "0xC")]
		internal UIAvatarUniversalDebrisExchangeController _0024this;

		[Token(Token = "0x600D459")]
		[Address(RVA = "0x2988FDC", Offset = "0x2988FDC", VA = "0x2988FDC")]
		public _003CInitView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D45A")]
		[Address(RVA = "0x2989A68", Offset = "0x2989A68", VA = "0x2989A68")]
		internal bool _003C_003Em__0(AvatarProfile a)
		{
			return default(bool);
		}

		[Token(Token = "0x600D45B")]
		[Address(RVA = "0x2989B30", Offset = "0x2989B30", VA = "0x2989B30")]
		internal bool _003C_003Em__1(AvatarProfile e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20024DF")]
	private sealed class _003CGCommon_IUIModelDataChangeObserver_OnDataChanged_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E494")]
		[FieldOffset(Offset = "0x8")]
		internal object[] param;

		[Token(Token = "0x600D45C")]
		[Address(RVA = "0x2989848", Offset = "0x2989848", VA = "0x2989848")]
		public _003CGCommon_IUIModelDataChangeObserver_OnDataChanged_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D45D")]
		[Address(RVA = "0x298998C", Offset = "0x298998C", VA = "0x298998C")]
		internal bool _003C_003Em__0(AvatarProfile e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E487")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarUniversalDebrisExchangeView m_View;

	[Token(Token = "0x400E488")]
	[FieldOffset(Offset = "0x4C")]
	private List<AvatarProfile> m_ShowAvatarList;

	[Token(Token = "0x400E489")]
	[FieldOffset(Offset = "0x50")]
	private UIModelAvatarProfile m_ProfileModel;

	[Token(Token = "0x400E48A")]
	[FieldOffset(Offset = "0x54")]
	private int m_UniversalDebrisCnt;

	[Token(Token = "0x400E48B")]
	[FieldOffset(Offset = "0x58")]
	private int m_ExchangeDebrisCnt;

	[Token(Token = "0x400E48C")]
	[FieldOffset(Offset = "0x5C")]
	private BoxCollider m_Collider;

	[Token(Token = "0x400E48D")]
	[FieldOffset(Offset = "0x60")]
	private AvatarProfile m_CurrentAvatarPofile;

	[Token(Token = "0x400E48E")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsBtnClick;

	[Token(Token = "0x400E48F")]
	[FieldOffset(Offset = "0x68")]
	private Color NORMAL_COLOR;

	[Token(Token = "0x400E490")]
	[FieldOffset(Offset = "0x78")]
	private Color DISABLE_COLOR;

	[Token(Token = "0x400E491")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AvatarProfile> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D442")]
	[Address(RVA = "0x2986FE0", Offset = "0x2986FE0", VA = "0x2986FE0")]
	public UIAvatarUniversalDebrisExchangeController()
	{
	}

	[Token(Token = "0x600D443")]
	[Address(RVA = "0x2987074", Offset = "0x2987074", VA = "0x2987074")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D444")]
	[Address(RVA = "0x298711C", Offset = "0x298711C", VA = "0x298711C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D445")]
	[Address(RVA = "0x298761C", Offset = "0x298761C", VA = "0x298761C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D446")]
	[Address(RVA = "0x29877A0", Offset = "0x29877A0", VA = "0x29877A0")]
	private void OnSelectAvatarheadItem(object[] data)
	{
	}

	[Token(Token = "0x600D447")]
	[Address(RVA = "0x2988200", Offset = "0x2988200", VA = "0x2988200", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D448")]
	[Address(RVA = "0x2988264", Offset = "0x2988264", VA = "0x2988264")]
	private void OnUseBtnClick()
	{
	}

	[Token(Token = "0x600D449")]
	[Address(RVA = "0x29885C0", Offset = "0x29885C0", VA = "0x29885C0")]
	private void OnSliderChanged()
	{
	}

	[Token(Token = "0x600D44A")]
	[Address(RVA = "0x2988684", Offset = "0x2988684", VA = "0x2988684")]
	private void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x600D44B")]
	[Address(RVA = "0x2988760", Offset = "0x2988760", VA = "0x2988760")]
	private void OnMinusBtnClick()
	{
	}

	[Token(Token = "0x600D44C")]
	[Address(RVA = "0x2988838", Offset = "0x2988838", VA = "0x2988838")]
	private void OnExchangeAllBtnClick()
	{
	}

	[Token(Token = "0x600D44D")]
	[Address(RVA = "0x2988AD8", Offset = "0x2988AD8", VA = "0x2988AD8")]
	public void InitView(uint avatarID)
	{
	}

	[Token(Token = "0x600D44E")]
	[Address(RVA = "0x2987C20", Offset = "0x2987C20", VA = "0x2987C20")]
	public void RefreshSliderInfo()
	{
	}

	[Token(Token = "0x600D44F")]
	[Address(RVA = "0x2987960", Offset = "0x2987960", VA = "0x2987960")]
	private void RefreshCurDebrisInfo()
	{
	}

	[Token(Token = "0x600D450")]
	[Address(RVA = "0x2988FE4", Offset = "0x2988FE4", VA = "0x2988FE4")]
	private void RefreshBtnState()
	{
	}

	[Token(Token = "0x600D451")]
	[Address(RVA = "0x29892A0", Offset = "0x29892A0", VA = "0x29892A0", Slot = "47")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D452")]
	[Address(RVA = "0x298931C", Offset = "0x298931C", VA = "0x298931C", Slot = "46")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D453")]
	[Address(RVA = "0x298945C", Offset = "0x298945C", VA = "0x298945C", Slot = "48")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D454")]
	[Address(RVA = "0x2989850", Offset = "0x2989850", VA = "0x2989850", Slot = "49")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D455")]
	[Address(RVA = "0x29898E4", Offset = "0x29898E4", VA = "0x29898E4")]
	private static int _003CInitView_003Em__0(AvatarProfile ap1, AvatarProfile ap2)
	{
		return default(int);
	}

	[Token(Token = "0x600D456")]
	[Address(RVA = "0x2989974", Offset = "0x2989974", VA = "0x2989974")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D457")]
	[Address(RVA = "0x298997C", Offset = "0x298997C", VA = "0x298997C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D458")]
	[Address(RVA = "0x2989984", Offset = "0x2989984", VA = "0x2989984")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
