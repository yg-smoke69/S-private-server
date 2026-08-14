using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038AE")]
public class UIMemberShipSVIPPrivilegePopWndView : UIBaseView
{
	[Token(Token = "0x401770B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ActiveTag;

	[Token(Token = "0x401770C")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x401770D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DailyExtraRewardLabel;

	[Token(Token = "0x401770E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MoreExtraRewardLabel;

	[Token(Token = "0x401770F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel WeekCardLock;

	[Token(Token = "0x4017710")]
	[FieldOffset(Offset = "0x28")]
	public UILabel WeekCardUnlock;

	[Token(Token = "0x4017711")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel MonthCardLock;

	[Token(Token = "0x4017712")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MonthCardUnLock;

	[Token(Token = "0x4017713")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CloseBtn;

	[Token(Token = "0x4017714")]
	[FieldOffset(Offset = "0x38")]
	public UIButton UnLockBtn;

	[Token(Token = "0x4017715")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton CheckInBtn;

	[Token(Token = "0x4017716")]
	[FieldOffset(Offset = "0x40")]
	public UILabel CurrentPrice;

	[Token(Token = "0x4017717")]
	[FieldOffset(Offset = "0x44")]
	public UIButton MshopUnLockBtn;

	[Token(Token = "0x4017718")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PurchaseBtnContainer;

	[Token(Token = "0x6016DB5")]
	[Address(RVA = "0x13026F8", Offset = "0x13026F8", VA = "0x13026F8")]
	public UIMemberShipSVIPPrivilegePopWndView()
	{
	}

	[Token(Token = "0x6016DB6")]
	[Address(RVA = "0x1302700", Offset = "0x1302700", VA = "0x1302700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DB7")]
	[Address(RVA = "0x1302D70", Offset = "0x1302D70", VA = "0x1302D70")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
