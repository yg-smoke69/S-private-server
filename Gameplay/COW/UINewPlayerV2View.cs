using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C6")]
public class UINewPlayerV2View : UIBaseView
{
	[Token(Token = "0x4017864")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UINewPlayerV2;

	[Token(Token = "0x4017865")]
	[FieldOffset(Offset = "0x18")]
	public Transform leftTabContainer;

	[Token(Token = "0x4017866")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject countDown;

	[Token(Token = "0x4017867")]
	[FieldOffset(Offset = "0x20")]
	public UIButton helpBtn;

	[Token(Token = "0x4017868")]
	[FieldOffset(Offset = "0x24")]
	public Transform taskContainer;

	[Token(Token = "0x4017869")]
	[FieldOffset(Offset = "0x28")]
	public Transform questionnair;

	[Token(Token = "0x401786A")]
	[FieldOffset(Offset = "0x2C")]
	public Transform bottomButtons;

	[Token(Token = "0x401786B")]
	[FieldOffset(Offset = "0x30")]
	public Transform signContainer;

	[Token(Token = "0x401786C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HintBubble;

	[Token(Token = "0x401786D")]
	[FieldOffset(Offset = "0x38")]
	public UISprite HintBg;

	[Token(Token = "0x401786E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BubbleLabel;

	[Token(Token = "0x401786F")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016DFD")]
	[Address(RVA = "0x27B3300", Offset = "0x27B3300", VA = "0x27B3300")]
	public UINewPlayerV2View()
	{
	}

	[Token(Token = "0x6016DFE")]
	[Address(RVA = "0x27B3308", Offset = "0x27B3308", VA = "0x27B3308", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DFF")]
	[Address(RVA = "0x27B37F0", Offset = "0x27B37F0", VA = "0x27B37F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
