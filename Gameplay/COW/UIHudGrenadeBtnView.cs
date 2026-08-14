using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003668")]
public class UIHudGrenadeBtnView : UIBaseView
{
	[Token(Token = "0x4015D4A")]
	[FieldOffset(Offset = "0x14")]
	public UISprite OpenBg;

	[Token(Token = "0x4015D4B")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid SubList;

	[Token(Token = "0x4015D4C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Horizon;

	[Token(Token = "0x4015D4D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnGrenade;

	[Token(Token = "0x4015D4E")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget BtnWidget;

	[Token(Token = "0x4015D4F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BGGrenade;

	[Token(Token = "0x4015D50")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Highlight;

	[Token(Token = "0x4015D51")]
	[FieldOffset(Offset = "0x30")]
	public UISprite icon;

	[Token(Token = "0x4015D52")]
	[FieldOffset(Offset = "0x34")]
	public GameObject iconbg;

	[Token(Token = "0x4015D53")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015D54")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel count;

	[Token(Token = "0x4015D55")]
	[FieldOffset(Offset = "0x40")]
	public UIButton arrowBtn;

	[Token(Token = "0x4015D56")]
	[FieldOffset(Offset = "0x44")]
	public UISprite arrowSpriteRight;

	[Token(Token = "0x4015D57")]
	[FieldOffset(Offset = "0x48")]
	public UISprite arrowSpriteLeft;

	[Token(Token = "0x4015D58")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite chargeprogress;

	[Token(Token = "0x4015D59")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Vertical;

	[Token(Token = "0x4015D5A")]
	[FieldOffset(Offset = "0x54")]
	public UIButton BtnGrenadeVer;

	[Token(Token = "0x4015D5B")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget BtnWidgetVer;

	[Token(Token = "0x4015D5C")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BGGrenadeVer;

	[Token(Token = "0x4015D5D")]
	[FieldOffset(Offset = "0x60")]
	public UISprite iconVer;

	[Token(Token = "0x4015D5E")]
	[FieldOffset(Offset = "0x64")]
	public GameObject iconbgVer;

	[Token(Token = "0x4015D5F")]
	[FieldOffset(Offset = "0x68")]
	public UIButton arrowBtnVer;

	[Token(Token = "0x4015D60")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite arrowSpriteTop;

	[Token(Token = "0x4015D61")]
	[FieldOffset(Offset = "0x70")]
	public UISprite arrowSpriteBottom;

	[Token(Token = "0x4015D62")]
	[FieldOffset(Offset = "0x74")]
	public UILabel countVer;

	[Token(Token = "0x4015D63")]
	[FieldOffset(Offset = "0x78")]
	public UISprite chargeprogressVer;

	[Token(Token = "0x4015D64")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject vfxReady;

	[Token(Token = "0x4015D65")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SmartIceWall;

	[Token(Token = "0x4015D66")]
	[FieldOffset(Offset = "0x84")]
	public UILabel IceWallCnt;

	[Token(Token = "0x4015D67")]
	[FieldOffset(Offset = "0x88")]
	public UISprite IceWallIcon;

	[Token(Token = "0x4015D68")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton SmartIceWallBtn;

	[Token(Token = "0x4015D69")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Normal;

	[Token(Token = "0x4015D6A")]
	[FieldOffset(Offset = "0x94")]
	public UISprite SmartIceWallBG;

	[Token(Token = "0x4015D6B")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CircleCon;

	[Token(Token = "0x4015D6C")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject SelectCircle1;

	[Token(Token = "0x4015D6D")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject SelectCircle2;

	[Token(Token = "0x4015D6E")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject SelectCircle3;

	[Token(Token = "0x4015D6F")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject SelectCircle4;

	[Token(Token = "0x4015D70")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject SelectCircle5;

	[Token(Token = "0x4015D71")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject SelectCircle6;

	[Token(Token = "0x4015D72")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject SelectCircle7;

	[Token(Token = "0x4015D73")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject SelectCircle8;

	[Token(Token = "0x4015D74")]
	[FieldOffset(Offset = "0xBC")]
	public UIWidget GrenadeDir;

	[Token(Token = "0x4015D75")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget GrenadeDirCon;

	[Token(Token = "0x60166E5")]
	[Address(RVA = "0x1332618", Offset = "0x1332618", VA = "0x1332618")]
	public UIHudGrenadeBtnView()
	{
	}

	[Token(Token = "0x60166E6")]
	[Address(RVA = "0x1332620", Offset = "0x1332620", VA = "0x1332620", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166E7")]
	[Address(RVA = "0x1333704", Offset = "0x1333704", VA = "0x1333704")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
