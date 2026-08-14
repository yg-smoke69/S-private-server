using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003825")]
public class UILengendGachaPreviewPopWndView : UIBaseView
{
	[Token(Token = "0x4016E20")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OkBtn;

	[Token(Token = "0x4016E21")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4016E22")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x6016C1A")]
	[Address(RVA = "0x254A658", Offset = "0x254A658", VA = "0x254A658")]
	public UILengendGachaPreviewPopWndView()
	{
	}

	[Token(Token = "0x6016C1B")]
	[Address(RVA = "0x254A660", Offset = "0x254A660", VA = "0x254A660", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C1C")]
	[Address(RVA = "0x254A8C8", Offset = "0x254A8C8", VA = "0x254A8C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
