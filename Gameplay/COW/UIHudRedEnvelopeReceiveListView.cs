using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003704")]
internal class UIHudRedEnvelopeReceiveListView : UIBaseView
{
	[Token(Token = "0x4016378")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4016379")]
	[FieldOffset(Offset = "0x18")]
	public UILabel OwnerLabel;

	[Token(Token = "0x401637A")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x401637B")]
	[FieldOffset(Offset = "0x20")]
	public RedEnvelopeAwardItemView ReceiveItem;

	[Token(Token = "0x60168B7")]
	[Address(RVA = "0x13DE784", Offset = "0x13DE784", VA = "0x13DE784")]
	public UIHudRedEnvelopeReceiveListView()
	{
	}

	[Token(Token = "0x60168B8")]
	[Address(RVA = "0x13DE78C", Offset = "0x13DE78C", VA = "0x13DE78C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168B9")]
	[Address(RVA = "0x13DEA54", Offset = "0x13DEA54", VA = "0x13DEA54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
