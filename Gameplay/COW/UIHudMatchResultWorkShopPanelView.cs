using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B2")]
public class UIHudMatchResultWorkShopPanelView : UIBaseView
{
	[Token(Token = "0x4016089")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIHudMatchResultWorkShopPanel;

	[Token(Token = "0x401608A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel WWorkshopName;

	[Token(Token = "0x401608B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject WorkshopBtns;

	[Token(Token = "0x401608C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton WLikeBtn;

	[Token(Token = "0x401608D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WVFX_Like;

	[Token(Token = "0x401608E")]
	[FieldOffset(Offset = "0x28")]
	public UIButton WSubBtn;

	[Token(Token = "0x401608F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Idle;

	[Token(Token = "0x4016090")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Subed;

	[Token(Token = "0x4016091")]
	[FieldOffset(Offset = "0x34")]
	public UIButton WDislikeBtn;

	[Token(Token = "0x4016092")]
	[FieldOffset(Offset = "0x38")]
	public GameObject dislikeIcon;

	[Token(Token = "0x4016093")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject MapDetailLabel;

	[Token(Token = "0x4016094")]
	[FieldOffset(Offset = "0x40")]
	public UIButton MapDetailBtn;

	[Token(Token = "0x4016095")]
	[FieldOffset(Offset = "0x44")]
	public GameObject WVFX_chuxian;

	[Token(Token = "0x4016096")]
	[FieldOffset(Offset = "0x48")]
	public UIButton WCommentBtn;

	[Token(Token = "0x4016097")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x60167C3")]
	[Address(RVA = "0x19C3A48", Offset = "0x19C3A48", VA = "0x19C3A48")]
	public UIHudMatchResultWorkShopPanelView()
	{
	}

	[Token(Token = "0x60167C4")]
	[Address(RVA = "0x19C3A50", Offset = "0x19C3A50", VA = "0x19C3A50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167C5")]
	[Address(RVA = "0x19C40D8", Offset = "0x19C40D8", VA = "0x19C40D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
