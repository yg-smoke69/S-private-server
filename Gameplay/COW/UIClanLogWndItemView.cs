using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003450")]
public class UIClanLogWndItemView : UIBaseView
{
	[Token(Token = "0x40144AE")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SendTime;

	[Token(Token = "0x40144AF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Content;

	[Token(Token = "0x60160A4")]
	[Address(RVA = "0x2B34F50", Offset = "0x2B34F50", VA = "0x2B34F50")]
	public UIClanLogWndItemView()
	{
	}

	[Token(Token = "0x60160A5")]
	[Address(RVA = "0x2B34F58", Offset = "0x2B34F58", VA = "0x2B34F58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160A6")]
	[Address(RVA = "0x2B35160", Offset = "0x2B35160", VA = "0x2B35160")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
