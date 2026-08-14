using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003816")]
public class UILauncherPopupMessageView : UIBaseView
{
	[Token(Token = "0x4016D0E")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainWidget;

	[Token(Token = "0x4016D0F")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel FullScreenRect;

	[Token(Token = "0x4016D10")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VersionNode;

	[Token(Token = "0x4016D11")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDNList;

	[Token(Token = "0x4016D12")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView CDNScrollView;

	[Token(Token = "0x4016D13")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture CdnTextureInstance;

	[Token(Token = "0x4016D14")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid CDNGrid;

	[Token(Token = "0x4016D15")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid DotGrid;

	[Token(Token = "0x4016D16")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget WebView;

	[Token(Token = "0x4016D17")]
	[FieldOffset(Offset = "0x38")]
	public UINetworkTexture BillboardCDNBG;

	[Token(Token = "0x4016D18")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnPatchNote;

	[Token(Token = "0x4016D19")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BtnPatchLabel;

	[Token(Token = "0x4016D1A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BtnOKGO;

	[Token(Token = "0x4016D1B")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnOK;

	[Token(Token = "0x4016D1C")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BtnOKLabel;

	[Token(Token = "0x4016D1D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject MaxHint;

	[Token(Token = "0x4016D1E")]
	[FieldOffset(Offset = "0x54")]
	public GameObject UpdateLabel;

	[Token(Token = "0x4016D1F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel UpdateInfo;

	[Token(Token = "0x4016D20")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject TextInfo;

	[Token(Token = "0x4016D21")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Info;

	[Token(Token = "0x4016D22")]
	[FieldOffset(Offset = "0x64")]
	public UILabel Title;

	[Token(Token = "0x4016D23")]
	[FieldOffset(Offset = "0x68")]
	public GameObject MaintenancePic;

	[Token(Token = "0x4016D24")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject ErrorPic;

	[Token(Token = "0x4016D25")]
	[FieldOffset(Offset = "0x70")]
	public GameObject UpdatePic;

	[Token(Token = "0x4016D26")]
	[FieldOffset(Offset = "0x74")]
	public UIButton TxtInfoOkBtn;

	[Token(Token = "0x4016D27")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TxtInfoOkLabel;

	[Token(Token = "0x6016BED")]
	[Address(RVA = "0x1A87BFC", Offset = "0x1A87BFC", VA = "0x1A87BFC")]
	public UILauncherPopupMessageView()
	{
	}

	[Token(Token = "0x6016BEE")]
	[Address(RVA = "0x1A87C04", Offset = "0x1A87C04", VA = "0x1A87C04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BEF")]
	[Address(RVA = "0x1A886A0", Offset = "0x1A886A0", VA = "0x1A886A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
