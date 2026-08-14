using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A9")]
public class UIMemberShipReissueView : UIBaseView
{
	[Token(Token = "0x40176E7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Number;

	[Token(Token = "0x40176E8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton DetailTipBtn;

	[Token(Token = "0x40176E9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x40176EA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NoVipTips;

	[Token(Token = "0x40176EB")]
	[FieldOffset(Offset = "0x24")]
	public UIButton GoToPayBtn;

	[Token(Token = "0x40176EC")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016DA6")]
	[Address(RVA = "0x12FFAC4", Offset = "0x12FFAC4", VA = "0x12FFAC4")]
	public UIMemberShipReissueView()
	{
	}

	[Token(Token = "0x6016DA7")]
	[Address(RVA = "0x12FFACC", Offset = "0x12FFACC", VA = "0x12FFACC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DA8")]
	[Address(RVA = "0x12FFE48", Offset = "0x12FFE48", VA = "0x12FFE48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
