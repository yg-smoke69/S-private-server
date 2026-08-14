using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003399")]
public class UGCInfectionChangePanelView : UIBaseView
{
	[Token(Token = "0x4013AF8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4013AF9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Time;

	[Token(Token = "0x4013AFA")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ItemScroll;

	[Token(Token = "0x4013AFB")]
	[FieldOffset(Offset = "0x20")]
	public UITable ItemRoot;

	[Token(Token = "0x6015E81")]
	[Address(RVA = "0x29F2880", Offset = "0x29F2880", VA = "0x29F2880")]
	public UGCInfectionChangePanelView()
	{
	}

	[Token(Token = "0x6015E82")]
	[Address(RVA = "0x29F2888", Offset = "0x29F2888", VA = "0x29F2888", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E83")]
	[Address(RVA = "0x29F2B50", Offset = "0x29F2B50", VA = "0x29F2B50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
