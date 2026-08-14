using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F6")]
public class UIImageShareCaptureWidgetView : UIBaseView
{
	[Token(Token = "0x4016B78")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LandScapeView;

	[Token(Token = "0x4016B79")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftTopBg;

	[Token(Token = "0x4016B7A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Head;

	[Token(Token = "0x4016B7B")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x4016B7C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HeadLocalIcon;

	[Token(Token = "0x4016B7D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Name;

	[Token(Token = "0x4016B7E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ID;

	[Token(Token = "0x4016B7F")]
	[FieldOffset(Offset = "0x30")]
	public UIEffectSprite bg;

	[Token(Token = "0x4016B80")]
	[FieldOffset(Offset = "0x34")]
	public GameObject fakeBg;

	[Token(Token = "0x4016B81")]
	[FieldOffset(Offset = "0x38")]
	public UISprite TopBarBg;

	[Token(Token = "0x4016B82")]
	[FieldOffset(Offset = "0x3C")]
	public Transform LeftLogo;

	[Token(Token = "0x4016B83")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PortraitView;

	[Token(Token = "0x4016B84")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BG;

	[Token(Token = "0x4016B85")]
	[FieldOffset(Offset = "0x48")]
	public GameObject LeftBottom;

	[Token(Token = "0x4016B86")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BasicInfo;

	[Token(Token = "0x4016B87")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Head_P;

	[Token(Token = "0x4016B88")]
	[FieldOffset(Offset = "0x54")]
	public UINetworkTexture HeadIcon_P;

	[Token(Token = "0x4016B89")]
	[FieldOffset(Offset = "0x58")]
	public UISprite HeadLocalIcon_P;

	[Token(Token = "0x4016B8A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel Name_P;

	[Token(Token = "0x4016B8B")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ID_P;

	[Token(Token = "0x4016B8C")]
	[FieldOffset(Offset = "0x64")]
	public UIEffectSprite bg_P;

	[Token(Token = "0x4016B8D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject fakeBg_P;

	[Token(Token = "0x4016B8E")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject RightBottom;

	[Token(Token = "0x4016B8F")]
	[FieldOffset(Offset = "0x70")]
	public Transform RightLogo;

	[Token(Token = "0x6016B8D")]
	[Address(RVA = "0xD48420", Offset = "0xD48420", VA = "0xD48420")]
	public UIImageShareCaptureWidgetView()
	{
	}

	[Token(Token = "0x6016B8E")]
	[Address(RVA = "0xD48428", Offset = "0xD48428", VA = "0xD48428", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B8F")]
	[Address(RVA = "0xD48DC0", Offset = "0xD48DC0", VA = "0xD48DC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
