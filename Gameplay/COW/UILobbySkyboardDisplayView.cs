using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003850")]
public class UILobbySkyboardDisplayView : UIBaseView
{
	[Token(Token = "0x4017112")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition RightTween;

	[Token(Token = "0x4017113")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4017114")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GotoShopCollectionSkin;

	[Token(Token = "0x4017115")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017116")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList Grid;

	[Token(Token = "0x4017117")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CenterButton;

	[Token(Token = "0x4017118")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RemoveButton;

	[Token(Token = "0x4017119")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget GuideRoot;

	[Token(Token = "0x401711A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton AutoRotateToggle;

	[Token(Token = "0x401711B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ShowOn;

	[Token(Token = "0x401711C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ShowOff;

	[Token(Token = "0x401711D")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget AutoRotateGuideRoot;

	[Token(Token = "0x401711E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NaviPage;

	[Token(Token = "0x401711F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton HelpBtn;

	[Token(Token = "0x4017120")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LeaveBtn;

	[Token(Token = "0x6016C9B")]
	[Address(RVA = "0x1CBA428", Offset = "0x1CBA428", VA = "0x1CBA428")]
	public UILobbySkyboardDisplayView()
	{
	}

	[Token(Token = "0x6016C9C")]
	[Address(RVA = "0x1CBA430", Offset = "0x1CBA430", VA = "0x1CBA430", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C9D")]
	[Address(RVA = "0x1CBAAF4", Offset = "0x1CBAAF4", VA = "0x1CBAAF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
