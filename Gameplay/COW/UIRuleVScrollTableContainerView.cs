using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398B")]
public class UIRuleVScrollTableContainerView : UIBaseView
{
	[Token(Token = "0x4018198")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Self;

	[Token(Token = "0x4018199")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ScrollableArea;

	[Token(Token = "0x401819A")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x401819B")]
	[FieldOffset(Offset = "0x20")]
	public UITable CContainer;

	[Token(Token = "0x6017048")]
	[Address(RVA = "0x1429740", Offset = "0x1429740", VA = "0x1429740")]
	public UIRuleVScrollTableContainerView()
	{
	}

	[Token(Token = "0x6017049")]
	[Address(RVA = "0x1429748", Offset = "0x1429748", VA = "0x1429748", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601704A")]
	[Address(RVA = "0x1429A10", Offset = "0x1429A10", VA = "0x1429A10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
