using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029BF")]
public class UIMemberShipReissueController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x20029C0")]
	private sealed class _003CRefreshViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x40100EB")]
		[FieldOffset(Offset = "0x8")]
		internal DateTime currentLocalDateTime;

		[Token(Token = "0x6010CA6")]
		[Address(RVA = "0x12FD180", Offset = "0x12FD180", VA = "0x12FD180")]
		public _003CRefreshViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010CA7")]
		[Address(RVA = "0x12FD934", Offset = "0x12FD934", VA = "0x12FD934")]
		internal bool _003C_003Em__0(ClientReissueItemData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40100E7")]
	[FieldOffset(Offset = "0x48")]
	private UIMemberShipReissueView m_View;

	[Token(Token = "0x40100E8")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100E9")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 m_DragAmount;

	[Token(Token = "0x40100EA")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ClientReissueItemData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010C94")]
	[Address(RVA = "0x12FC250", Offset = "0x12FC250", VA = "0x12FC250")]
	public UIMemberShipReissueController()
	{
	}

	[Token(Token = "0x6010C95")]
	[Address(RVA = "0x12FC258", Offset = "0x12FC258", VA = "0x12FC258")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C96")]
	[Address(RVA = "0x12FC2FC", Offset = "0x12FC2FC", VA = "0x12FC2FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C97")]
	[Address(RVA = "0x12FCDB0", Offset = "0x12FCDB0", VA = "0x12FCDB0", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x6010C98")]
	[Address(RVA = "0x12FCED4", Offset = "0x12FCED4", VA = "0x12FCED4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010C99")]
	[Address(RVA = "0x12FCF5C", Offset = "0x12FCF5C", VA = "0x12FCF5C")]
	private void OnRequestReissue(object[] data)
	{
	}

	[Token(Token = "0x6010C9A")]
	[Address(RVA = "0x12FC5F4", Offset = "0x12FC5F4", VA = "0x12FC5F4")]
	private void RefreshViewData(bool isReissue = false)
	{
	}

	[Token(Token = "0x6010C9B")]
	[Address(RVA = "0x12FD188", Offset = "0x12FD188", VA = "0x12FD188")]
	private void RefreshOwnedReissueCardNum()
	{
	}

	[Token(Token = "0x6010C9C")]
	[Address(RVA = "0x12FD25C", Offset = "0x12FD25C", VA = "0x12FD25C")]
	private void OnGoToPayBtnClick()
	{
	}

	[Token(Token = "0x6010C9D")]
	[Address(RVA = "0x12FD430", Offset = "0x12FD430", VA = "0x12FD430", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010C9E")]
	[Address(RVA = "0x12FD544", Offset = "0x12FD544", VA = "0x12FD544")]
	private void OnDetailTipBtnClick()
	{
	}

	[Token(Token = "0x6010C9F")]
	[Address(RVA = "0x12FD6B4", Offset = "0x12FD6B4", VA = "0x12FD6B4", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010CA0")]
	[Address(RVA = "0x12FD76C", Offset = "0x12FD76C", VA = "0x12FD76C", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010CA1")]
	[Address(RVA = "0x12FD864", Offset = "0x12FD864", VA = "0x12FD864", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010CA2")]
	[Address(RVA = "0x12FD8E0", Offset = "0x12FD8E0", VA = "0x12FD8E0")]
	private static bool _003CRefreshViewData_003Em__0(ClientReissueItemData x)
	{
		return default(bool);
	}

	[Token(Token = "0x6010CA3")]
	[Address(RVA = "0x12FD91C", Offset = "0x12FD91C", VA = "0x12FD91C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010CA4")]
	[Address(RVA = "0x12FD924", Offset = "0x12FD924", VA = "0x12FD924")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x6010CA5")]
	[Address(RVA = "0x12FD92C", Offset = "0x12FD92C", VA = "0x12FD92C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
