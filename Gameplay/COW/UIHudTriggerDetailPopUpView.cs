using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003784")]
public class UIHudTriggerDetailPopUpView : UIBaseView
{
	[Token(Token = "0x40167F5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x40167F6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleLabel;

	[Token(Token = "0x40167F7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel2;

	[Token(Token = "0x40167F8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ClanLabel;

	[Token(Token = "0x40167F9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DescLabel;

	[Token(Token = "0x40167FA")]
	[FieldOffset(Offset = "0x28")]
	public UITexture TeamPic;

	[Token(Token = "0x40167FB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TeamLogo;

	[Token(Token = "0x6016A37")]
	[Address(RVA = "0x158AA64", Offset = "0x158AA64", VA = "0x158AA64")]
	public UIHudTriggerDetailPopUpView()
	{
	}

	[Token(Token = "0x6016A38")]
	[Address(RVA = "0x158AA6C", Offset = "0x158AA6C", VA = "0x158AA6C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A39")]
	[Address(RVA = "0x158AE54", Offset = "0x158AE54", VA = "0x158AE54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
