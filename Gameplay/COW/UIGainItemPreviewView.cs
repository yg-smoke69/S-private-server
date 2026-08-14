using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200359F")]
public class UIGainItemPreviewView : UIBaseView
{
	[Token(Token = "0x4015634")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4015635")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btnClose;

	[Token(Token = "0x4015636")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ScreenshotTopBanner;

	[Token(Token = "0x4015637")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x4015638")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x4015639")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x401563A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PlayerNickname;

	[Token(Token = "0x401563B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayerID;

	[Token(Token = "0x401563C")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ShareBtn;

	[Token(Token = "0x401563D")]
	[FieldOffset(Offset = "0x38")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x401563E")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton leaveBtn;

	[Token(Token = "0x401563F")]
	[FieldOffset(Offset = "0x40")]
	public UISprite iconBg;

	[Token(Token = "0x4015640")]
	[FieldOffset(Offset = "0x44")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015641")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget PreViewCommonContainer;

	[Token(Token = "0x601648D")]
	[Address(RVA = "0x245EA64", Offset = "0x245EA64", VA = "0x245EA64")]
	public UIGainItemPreviewView()
	{
	}

	[Token(Token = "0x601648E")]
	[Address(RVA = "0x245EA6C", Offset = "0x245EA6C", VA = "0x245EA6C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601648F")]
	[Address(RVA = "0x245F0DC", Offset = "0x245F0DC", VA = "0x245F0DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
