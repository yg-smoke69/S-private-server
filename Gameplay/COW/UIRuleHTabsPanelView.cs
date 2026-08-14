using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200397A")]
public class UIRuleHTabsPanelView : UIBaseView
{
	[Token(Token = "0x4018129")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x401812A")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView TabSchollView;

	[Token(Token = "0x401812B")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList TabContainer;

	[Token(Token = "0x401812C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SubLabel;

	[Token(Token = "0x401812D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UnselectableTitle;

	[Token(Token = "0x401812E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CContainer;

	[Token(Token = "0x6017015")]
	[Address(RVA = "0x2BF61E8", Offset = "0x2BF61E8", VA = "0x2BF61E8")]
	public UIRuleHTabsPanelView()
	{
	}

	[Token(Token = "0x6017016")]
	[Address(RVA = "0x2BF61F0", Offset = "0x2BF61F0", VA = "0x2BF61F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017017")]
	[Address(RVA = "0x2BF6560", Offset = "0x2BF6560", VA = "0x2BF6560")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
