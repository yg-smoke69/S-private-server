using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371E")]
public class UIHudSafeZoneInfoView : UIBaseView
{
	[Token(Token = "0x4016452")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoContainer;

	[Token(Token = "0x4016453")]
	[FieldOffset(Offset = "0x18")]
	public GameObject warningTips;

	[Token(Token = "0x4016454")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject centerModeContainer;

	[Token(Token = "0x4016455")]
	[FieldOffset(Offset = "0x20")]
	public UILabel labelTips;

	[Token(Token = "0x4016456")]
	[FieldOffset(Offset = "0x24")]
	public UISprite labelbgwidget;

	[Token(Token = "0x4016457")]
	[FieldOffset(Offset = "0x28")]
	public UISprite warningIcon;

	[Token(Token = "0x4016458")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite warningwidget;

	[Token(Token = "0x4016459")]
	[FieldOffset(Offset = "0x30")]
	public UILabel timeCount;

	[Token(Token = "0x401645A")]
	[FieldOffset(Offset = "0x34")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x401645B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject miniModeContainer;

	[Token(Token = "0x401645C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite warningIconMini;

	[Token(Token = "0x401645D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel MiniTimeCount;

	[Token(Token = "0x401645E")]
	[FieldOffset(Offset = "0x44")]
	public TweenAlpha TweenAlphaMini;

	[Token(Token = "0x401645F")]
	[FieldOffset(Offset = "0x48")]
	public UISprite UAVIconMini;

	[Token(Token = "0x4016460")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel UAVLabelMini;

	[Token(Token = "0x4016461")]
	[FieldOffset(Offset = "0x50")]
	public Animator WarningIconAnimator;

	[Token(Token = "0x4016462")]
	[FieldOffset(Offset = "0x54")]
	public UISprite attentionwidget;

	[Token(Token = "0x4016463")]
	[FieldOffset(Offset = "0x58")]
	public UISprite WarningBG;

	[Token(Token = "0x6016905")]
	[Address(RVA = "0x1C46D04", Offset = "0x1C46D04", VA = "0x1C46D04")]
	public UIHudSafeZoneInfoView()
	{
	}

	[Token(Token = "0x6016906")]
	[Address(RVA = "0x1C46D0C", Offset = "0x1C46D0C", VA = "0x1C46D0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016907")]
	[Address(RVA = "0x1C474E4", Offset = "0x1C474E4", VA = "0x1C474E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
