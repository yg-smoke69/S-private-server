using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DE")]
public class UIAvatarUniversalDebrisExchangeView : UIBaseView
{
	[Token(Token = "0x4013ECE")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList AvatarEasyList;

	[Token(Token = "0x4013ECF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CurExchangedCnt;

	[Token(Token = "0x4013ED0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel universalDebrisCnt;

	[Token(Token = "0x4013ED1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite currentDebrisIcon;

	[Token(Token = "0x4013ED2")]
	[FieldOffset(Offset = "0x24")]
	public UILabel currentAvatarName;

	[Token(Token = "0x4013ED3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel currentDebrisCnt;

	[Token(Token = "0x4013ED4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton plusBtn;

	[Token(Token = "0x4013ED5")]
	[FieldOffset(Offset = "0x30")]
	public UIButton minusBtn;

	[Token(Token = "0x4013ED6")]
	[FieldOffset(Offset = "0x34")]
	public UIButton exchangeAllBtn;

	[Token(Token = "0x4013ED7")]
	[FieldOffset(Offset = "0x38")]
	public UISlider slider;

	[Token(Token = "0x4013ED8")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton UseBtn;

	[Token(Token = "0x4013ED9")]
	[FieldOffset(Offset = "0x40")]
	public UISprite BtnBG;

	[Token(Token = "0x6015F50")]
	[Address(RVA = "0x2989B68", Offset = "0x2989B68", VA = "0x2989B68")]
	public UIAvatarUniversalDebrisExchangeView()
	{
	}

	[Token(Token = "0x6015F51")]
	[Address(RVA = "0x2989B70", Offset = "0x2989B70", VA = "0x2989B70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F52")]
	[Address(RVA = "0x298A138", Offset = "0x298A138", VA = "0x298A138")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
