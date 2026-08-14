using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003703")]
internal class UIHudRedEnvelopeButtonListView : UIBaseView
{
	[Token(Token = "0x4016376")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4016377")]
	[FieldOffset(Offset = "0x18")]
	public RedEnvelopeItemView RedEnvelopeItem;

	[Token(Token = "0x60168B4")]
	[Address(RVA = "0x13DC2D4", Offset = "0x13DC2D4", VA = "0x13DC2D4")]
	public UIHudRedEnvelopeButtonListView()
	{
	}

	[Token(Token = "0x60168B5")]
	[Address(RVA = "0x13DC2DC", Offset = "0x13DC2DC", VA = "0x13DC2DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168B6")]
	[Address(RVA = "0x13DC4E4", Offset = "0x13DC4E4", VA = "0x13DC4E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
