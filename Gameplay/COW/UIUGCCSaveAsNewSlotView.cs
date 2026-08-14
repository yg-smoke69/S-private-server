using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A24")]
public class UIUGCCSaveAsNewSlotView : UIBaseView
{
	[Token(Token = "0x40188D0")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x40188D1")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x6017212")]
	[Address(RVA = "0x2B7F824", Offset = "0x2B7F824", VA = "0x2B7F824")]
	public UIUGCCSaveAsNewSlotView()
	{
	}

	[Token(Token = "0x6017213")]
	[Address(RVA = "0x2B7F82C", Offset = "0x2B7F82C", VA = "0x2B7F82C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017214")]
	[Address(RVA = "0x2B7FA34", Offset = "0x2B7FA34", VA = "0x2B7FA34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
