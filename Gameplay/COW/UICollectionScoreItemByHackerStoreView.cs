using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003470")]
public class UICollectionScoreItemByHackerStoreView : UIBaseView
{
	[Token(Token = "0x401464B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject pro;

	[Token(Token = "0x401464C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject down;

	[Token(Token = "0x401464D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite down3;

	[Token(Token = "0x401464E")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha alphaDown3;

	[Token(Token = "0x401464F")]
	[FieldOffset(Offset = "0x24")]
	public UISprite down2;

	[Token(Token = "0x4014650")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha alphaDown2;

	[Token(Token = "0x4014651")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite down1;

	[Token(Token = "0x4014652")]
	[FieldOffset(Offset = "0x30")]
	public TweenAlpha alphaDown1;

	[Token(Token = "0x4014653")]
	[FieldOffset(Offset = "0x34")]
	public GameObject up;

	[Token(Token = "0x4014654")]
	[FieldOffset(Offset = "0x38")]
	public UISprite up1;

	[Token(Token = "0x4014655")]
	[FieldOffset(Offset = "0x3C")]
	public TweenAlpha alphaUp1;

	[Token(Token = "0x4014656")]
	[FieldOffset(Offset = "0x40")]
	public UISprite up2;

	[Token(Token = "0x4014657")]
	[FieldOffset(Offset = "0x44")]
	public TweenAlpha alphaUp2;

	[Token(Token = "0x4014658")]
	[FieldOffset(Offset = "0x48")]
	public UISprite up3;

	[Token(Token = "0x4014659")]
	[FieldOffset(Offset = "0x4C")]
	public TweenAlpha alphaUp3;

	[Token(Token = "0x401465A")]
	[FieldOffset(Offset = "0x50")]
	public UILabel scoreName;

	[Token(Token = "0x401465B")]
	[FieldOffset(Offset = "0x54")]
	public TweenAlpha alphaName;

	[Token(Token = "0x401465C")]
	[FieldOffset(Offset = "0x58")]
	public UIProgressBar scoreBar;

	[Token(Token = "0x401465D")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BarFG;

	[Token(Token = "0x401465E")]
	[FieldOffset(Offset = "0x60")]
	public UISprite deltaFg;

	[Token(Token = "0x401465F")]
	[FieldOffset(Offset = "0x64")]
	public UILabel scoreValue;

	[Token(Token = "0x4014660")]
	[FieldOffset(Offset = "0x68")]
	public UILabel deltaValue;

	[Token(Token = "0x6016104")]
	[Address(RVA = "0x2CD5A64", Offset = "0x2CD5A64", VA = "0x2CD5A64")]
	public UICollectionScoreItemByHackerStoreView()
	{
	}

	[Token(Token = "0x6016105")]
	[Address(RVA = "0x2CD5A6C", Offset = "0x2CD5A6C", VA = "0x2CD5A6C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016106")]
	[Address(RVA = "0x2CD63D0", Offset = "0x2CD63D0", VA = "0x2CD63D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
