using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038EE")]
public class UIPaymentMemberShipView : UIBaseView
{
	[Token(Token = "0x4017A5B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentMemberShip;

	[Token(Token = "0x4017A5C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CheckInContainer;

	[Token(Token = "0x4017A5D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MemberShipContainer;

	[Token(Token = "0x4017A5E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RebateCardsContainer_WeekCard;

	[Token(Token = "0x4017A5F")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RebateCardsContainer_MonthCard;

	[Token(Token = "0x4017A60")]
	[FieldOffset(Offset = "0x28")]
	public UIButton SvipBtn;

	[Token(Token = "0x4017A61")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SVipActiveVfx;

	[Token(Token = "0x4017A62")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton MemberShipTab;

	[Token(Token = "0x4017A63")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton CheckInTab;

	[Token(Token = "0x4017A64")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RuleTipsBtn;

	[Token(Token = "0x4017A65")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LoadingContainer;

	[Token(Token = "0x6016E73")]
	[Address(RVA = "0x29DA0E0", Offset = "0x29DA0E0", VA = "0x29DA0E0")]
	public UIPaymentMemberShipView()
	{
	}

	[Token(Token = "0x6016E74")]
	[Address(RVA = "0x29DA0E8", Offset = "0x29DA0E8", VA = "0x29DA0E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E75")]
	[Address(RVA = "0x29DA614", Offset = "0x29DA614", VA = "0x29DA614")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
