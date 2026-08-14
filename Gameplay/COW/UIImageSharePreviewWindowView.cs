using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F7")]
public class UIImageSharePreviewWindowView : UIBaseView
{
	[Token(Token = "0x4016B90")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4016B91")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClosePortrait;

	[Token(Token = "0x4016B92")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ShareBtnGroupContainer;

	[Token(Token = "0x4016B93")]
	[FieldOffset(Offset = "0x20")]
	public Transform LandscapeGroup;

	[Token(Token = "0x4016B94")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnDownloadToAlbum;

	[Token(Token = "0x4016B95")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CopyShareLink;

	[Token(Token = "0x4016B96")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid Grid;

	[Token(Token = "0x4016B97")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ShareHint;

	[Token(Token = "0x4016B98")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLineShare;

	[Token(Token = "0x4016B99")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnFBShare;

	[Token(Token = "0x4016B9A")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnVKShare;

	[Token(Token = "0x4016B9B")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnGarenaShare;

	[Token(Token = "0x4016B9C")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnOtherShare;

	[Token(Token = "0x4016B9D")]
	[FieldOffset(Offset = "0x48")]
	public Transform PortraitGroup;

	[Token(Token = "0x4016B9E")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton CopyShareLink_P;

	[Token(Token = "0x4016B9F")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnDownloadToAlbum_P;

	[Token(Token = "0x4016BA0")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid Grid_P;

	[Token(Token = "0x4016BA1")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BtnLineShare_P;

	[Token(Token = "0x4016BA2")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnFBShare_P;

	[Token(Token = "0x4016BA3")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnVKShare_P;

	[Token(Token = "0x4016BA4")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnGarenaShare_P;

	[Token(Token = "0x4016BA5")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnOtherShare_P;

	[Token(Token = "0x4016BA6")]
	[FieldOffset(Offset = "0x6C")]
	public UITexture SharePreview;

	[Token(Token = "0x4016BA7")]
	[FieldOffset(Offset = "0x70")]
	public UIPanel TipsPanel;

	[Token(Token = "0x4016BA8")]
	[FieldOffset(Offset = "0x74")]
	public TweenAlpha TipsTween;

	[Token(Token = "0x4016BA9")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TipTxt;

	[Token(Token = "0x4016BAA")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject FBMessageIcon;

	[Token(Token = "0x4016BAB")]
	[FieldOffset(Offset = "0x80")]
	public GameObject FaceBookIcon;

	[Token(Token = "0x6016B90")]
	[Address(RVA = "0xD4E588", Offset = "0xD4E588", VA = "0xD4E588")]
	public UIImageSharePreviewWindowView()
	{
	}

	[Token(Token = "0x6016B91")]
	[Address(RVA = "0xD4E590", Offset = "0xD4E590", VA = "0xD4E590", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B92")]
	[Address(RVA = "0xD4F0C8", Offset = "0xD4F0C8", VA = "0xD4F0C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
