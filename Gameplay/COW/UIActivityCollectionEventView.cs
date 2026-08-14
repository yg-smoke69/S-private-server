using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A1")]
public class UIActivityCollectionEventView : UIBaseView
{
	[Token(Token = "0x4013B3D")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4013B3E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject IntroBG;

	[Token(Token = "0x4013B3F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IntroBGSprite;

	[Token(Token = "0x4013B40")]
	[FieldOffset(Offset = "0x20")]
	public UITable IntroRoot;

	[Token(Token = "0x4013B41")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Introduction;

	[Token(Token = "0x4013B42")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Time;

	[Token(Token = "0x4013B43")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Progress;

	[Token(Token = "0x4013B44")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ProgressNum;

	[Token(Token = "0x4013B45")]
	[FieldOffset(Offset = "0x34")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4013B46")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Content;

	[Token(Token = "0x4013B47")]
	[FieldOffset(Offset = "0x3C")]
	public UIScrollView SigninScrollView;

	[Token(Token = "0x4013B48")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid SigninGrid;

	[Token(Token = "0x4013B49")]
	[FieldOffset(Offset = "0x44")]
	public MultiShadowText MultiShadow;

	[Token(Token = "0x4013B4A")]
	[FieldOffset(Offset = "0x48")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4013B4B")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CountDown;

	[Token(Token = "0x4013B4C")]
	[FieldOffset(Offset = "0x50")]
	public UIButton CountDownBtn;

	[Token(Token = "0x4013B4D")]
	[FieldOffset(Offset = "0x54")]
	public UILabel InfoLabel0;

	[Token(Token = "0x4013B4E")]
	[FieldOffset(Offset = "0x58")]
	public UIButton TokenBtn0;

	[Token(Token = "0x4013B4F")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite TokenSprite0;

	[Token(Token = "0x4013B50")]
	[FieldOffset(Offset = "0x60")]
	public UILabel InfoLabel1;

	[Token(Token = "0x4013B51")]
	[FieldOffset(Offset = "0x64")]
	public UIButton TokenBtn1;

	[Token(Token = "0x4013B52")]
	[FieldOffset(Offset = "0x68")]
	public UISprite TokenSprite1;

	[Token(Token = "0x4013B53")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel InfoLabel2;

	[Token(Token = "0x4013B54")]
	[FieldOffset(Offset = "0x70")]
	public UIButton StoreBtn;

	[Token(Token = "0x4013B55")]
	[FieldOffset(Offset = "0x74")]
	public UIScrollView CollectionScrollView;

	[Token(Token = "0x4013B56")]
	[FieldOffset(Offset = "0x78")]
	public UITable CollectionTable;

	[Token(Token = "0x4013B57")]
	[FieldOffset(Offset = "0x7C")]
	public UINetworkTexture ExchangeBG;

	[Token(Token = "0x6015E99")]
	[Address(RVA = "0x2A0B4E0", Offset = "0x2A0B4E0", VA = "0x2A0B4E0")]
	public UIActivityCollectionEventView()
	{
	}

	[Token(Token = "0x6015E9A")]
	[Address(RVA = "0x2A0B4E8", Offset = "0x2A0B4E8", VA = "0x2A0B4E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E9B")]
	[Address(RVA = "0x2A0C020", Offset = "0x2A0C020", VA = "0x2A0C020")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
