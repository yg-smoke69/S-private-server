using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F0")]
public class UIHyperBookshelfNavigationView : UIBaseView
{
	[Token(Token = "0x4016B20")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView BookScrollView;

	[Token(Token = "0x4016B21")]
	[FieldOffset(Offset = "0x18")]
	public UITable BookTable;

	[Token(Token = "0x4016B22")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GuideMaskBtn;

	[Token(Token = "0x4016B23")]
	[FieldOffset(Offset = "0x20")]
	public Transform BookOpenVFXTrans;

	[Token(Token = "0x6016B7B")]
	[Address(RVA = "0xD38784", Offset = "0xD38784", VA = "0xD38784")]
	public UIHyperBookshelfNavigationView()
	{
	}

	[Token(Token = "0x6016B7C")]
	[Address(RVA = "0xD3878C", Offset = "0xD3878C", VA = "0xD3878C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B7D")]
	[Address(RVA = "0xD38A2C", Offset = "0xD38A2C", VA = "0xD38A2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
