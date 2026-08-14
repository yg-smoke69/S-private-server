using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200394C")]
public class UIRelationshipExtraPreviewWndView : UIBaseView
{
	[Token(Token = "0x4017FC4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OKBtn;

	[Token(Token = "0x4017FC5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BtnLabel;

	[Token(Token = "0x4017FC6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AccumulationLabel;

	[Token(Token = "0x4017FC7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTimes;

	[Token(Token = "0x4017FC8")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x6016F8B")]
	[Address(RVA = "0x1E48A10", Offset = "0x1E48A10", VA = "0x1E48A10")]
	public UIRelationshipExtraPreviewWndView()
	{
	}

	[Token(Token = "0x6016F8C")]
	[Address(RVA = "0x1E48A18", Offset = "0x1E48A18", VA = "0x1E48A18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F8D")]
	[Address(RVA = "0x1E48D40", Offset = "0x1E48D40", VA = "0x1E48D40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
