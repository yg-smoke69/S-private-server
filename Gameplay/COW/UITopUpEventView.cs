using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A03")]
public class UITopUpEventView : UIBaseView
{
	[Token(Token = "0x4018794")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TotalDiamondLabel;

	[Token(Token = "0x4018795")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TimeLabel;

	[Token(Token = "0x4018796")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018797")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4018798")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ProgressTable;

	[Token(Token = "0x4018799")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TitleLabel;

	[Token(Token = "0x401879A")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture CDNBG;

	[Token(Token = "0x401879B")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x401879C")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget PreviewBorderActivity;

	[Token(Token = "0x60171AF")]
	[Address(RVA = "0x2AFBBD4", Offset = "0x2AFBBD4", VA = "0x2AFBBD4")]
	public UITopUpEventView()
	{
	}

	[Token(Token = "0x60171B0")]
	[Address(RVA = "0x2AFBBDC", Offset = "0x2AFBBDC", VA = "0x2AFBBDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171B1")]
	[Address(RVA = "0x2AFC078", Offset = "0x2AFC078", VA = "0x2AFC078")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
