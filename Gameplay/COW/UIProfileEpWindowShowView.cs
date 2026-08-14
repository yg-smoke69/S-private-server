using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003927")]
public class UIProfileEpWindowShowView : UIBaseView
{
	[Token(Token = "0x4017CBD")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollViewRoot;

	[Token(Token = "0x4017CBE")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x4017CBF")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ItemListGridTF;

	[Token(Token = "0x4017CC0")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x6016F1C")]
	[Address(RVA = "0x16D69F8", Offset = "0x16D69F8", VA = "0x16D69F8")]
	public UIProfileEpWindowShowView()
	{
	}

	[Token(Token = "0x6016F1D")]
	[Address(RVA = "0x16D6A00", Offset = "0x16D6A00", VA = "0x16D6A00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F1E")]
	[Address(RVA = "0x16D6CA0", Offset = "0x16D6CA0", VA = "0x16D6CA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
