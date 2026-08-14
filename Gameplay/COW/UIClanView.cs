using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345A")]
public class UIClanView : UIBaseView
{
	[Token(Token = "0x4014540")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale TweenScale;

	[Token(Token = "0x4014541")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4014542")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BG;

	[Token(Token = "0x4014543")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClanShopBtn;

	[Token(Token = "0x4014544")]
	[FieldOffset(Offset = "0x24")]
	public Transform CountdownTime;

	[Token(Token = "0x4014545")]
	[FieldOffset(Offset = "0x28")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4014546")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite RaceOpenIcon;

	[Token(Token = "0x4014547")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DetailContent;

	[Token(Token = "0x4014548")]
	[FieldOffset(Offset = "0x34")]
	public GameObject MemberContent;

	[Token(Token = "0x4014549")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RaceContent;

	[Token(Token = "0x401454A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject TimeBG;

	[Token(Token = "0x401454B")]
	[FieldOffset(Offset = "0x40")]
	public UICountDownLabel TimeLabel;

	[Token(Token = "0x401454C")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ClanWarNewsContent;

	[Token(Token = "0x401454D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ClanWarScheduleContent;

	[Token(Token = "0x60160C2")]
	[Address(RVA = "0x2B4E9EC", Offset = "0x2B4E9EC", VA = "0x2B4E9EC")]
	public UIClanView()
	{
	}

	[Token(Token = "0x60160C3")]
	[Address(RVA = "0x2B4E9F4", Offset = "0x2B4E9F4", VA = "0x2B4E9F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160C4")]
	[Address(RVA = "0x2B4EFCC", Offset = "0x2B4EFCC", VA = "0x2B4EFCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
