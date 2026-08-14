using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003747")]
public class UIHudSingerCallDanceView : UIBaseView
{
	[Token(Token = "0x40165A7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SelectedLabel;

	[Token(Token = "0x40165A8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScreenShot;

	[Token(Token = "0x40165A9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ScreenShotSmallCard;

	[Token(Token = "0x40165AA")]
	[FieldOffset(Offset = "0x20")]
	public UITexture ScreenShotTexture;

	[Token(Token = "0x40165AB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DescLabel;

	[Token(Token = "0x40165AC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountDownLabel;

	[Token(Token = "0x40165AD")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton YesBtn;

	[Token(Token = "0x40165AE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton NoBtn;

	[Token(Token = "0x40165AF")]
	[FieldOffset(Offset = "0x34")]
	public UITexture BigScreenShotTex;

	[Token(Token = "0x6016980")]
	[Address(RVA = "0x16BB638", Offset = "0x16BB638", VA = "0x16BB638")]
	public UIHudSingerCallDanceView()
	{
	}

	[Token(Token = "0x6016981")]
	[Address(RVA = "0x16BB640", Offset = "0x16BB640", VA = "0x16BB640", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016982")]
	[Address(RVA = "0x16BBAD0", Offset = "0x16BBAD0", VA = "0x16BBAD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
