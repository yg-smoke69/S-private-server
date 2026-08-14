using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029BC")]
public class UIMemberShipCheckInItemController : UIBaseController
{
	[Token(Token = "0x20029BD")]
	public enum CheckInItemState
	{
		[Token(Token = "0x40100DB")]
		None,
		[Token(Token = "0x40100DC")]
		Nomral,
		[Token(Token = "0x40100DD")]
		Checked,
		[Token(Token = "0x40100DE")]
		Warn
	}

	[Token(Token = "0x40100D2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color WARNCOLOR;

	[Token(Token = "0x40100D3")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color NORMALCOLOR;

	[Token(Token = "0x40100D4")]
	[FieldOffset(Offset = "0x28")]
	private EVipCard.VipCardType m_MemberShipCardType;

	[Token(Token = "0x40100D5")]
	[FieldOffset(Offset = "0x2C")]
	private CheckInItemState m_CheckInItemState;

	[Token(Token = "0x40100D6")]
	[FieldOffset(Offset = "0x30")]
	private UIMemberShipCheckInItemView m_View;

	[Token(Token = "0x40100D7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x40100D8")]
	[FieldOffset(Offset = "0x38")]
	private ClientMemberShipCardData m_Data;

	[Token(Token = "0x40100D9")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIStandardItemMiniController> m_ItemsList;

	[Token(Token = "0x6010C66")]
	[Address(RVA = "0x269AD54", Offset = "0x269AD54", VA = "0x269AD54")]
	public UIMemberShipCheckInItemController()
	{
	}

	[Token(Token = "0x6010C67")]
	[Address(RVA = "0x269AE0C", Offset = "0x269AE0C", VA = "0x269AE0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C68")]
	[Address(RVA = "0x269AEB0", Offset = "0x269AEB0", VA = "0x269AEB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C69")]
	[Address(RVA = "0x26993E4", Offset = "0x26993E4", VA = "0x26993E4")]
	public void SetViewData(EVipCard.VipCardType memberShipCardType)
	{
	}

	[Token(Token = "0x6010C6A")]
	[Address(RVA = "0x269B0F0", Offset = "0x269B0F0", VA = "0x269B0F0")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x6010C6B")]
	[Address(RVA = "0x269BA34", Offset = "0x269BA34", VA = "0x269BA34")]
	private void OnNormalConfirmClick()
	{
	}

	[Token(Token = "0x6010C6C")]
	[Address(RVA = "0x269BAEC", Offset = "0x269BAEC", VA = "0x269BAEC")]
	private void OnSvipSecondConfirmClick()
	{
	}

	[Token(Token = "0x6010C6D")]
	[Address(RVA = "0x269BBBC", Offset = "0x269BBBC", VA = "0x269BBBC")]
	private void OnReBuyBtnClick()
	{
	}

	[Token(Token = "0x6010C6E")]
	[Address(RVA = "0x269B1B0", Offset = "0x269B1B0", VA = "0x269B1B0")]
	private void TryPurchaseMembershipCard()
	{
	}

	[Token(Token = "0x6010C70")]
	[Address(RVA = "0x269BD08", Offset = "0x269BD08", VA = "0x269BD08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
