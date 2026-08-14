using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0A")]
public class UITrainingCampMsgWndView : UIBaseView
{
	[Token(Token = "0x40187C0")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList msgGrid;

	[Token(Token = "0x40187C1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NoneMsgLabel;

	[Token(Token = "0x40187C2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel EmptyLabel;

	[Token(Token = "0x60171C4")]
	[Address(RVA = "0x1C1E3AC", Offset = "0x1C1E3AC", VA = "0x1C1E3AC")]
	public UITrainingCampMsgWndView()
	{
	}

	[Token(Token = "0x60171C5")]
	[Address(RVA = "0x1C1E3B4", Offset = "0x1C1E3B4", VA = "0x1C1E3B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171C6")]
	[Address(RVA = "0x1C1E610", Offset = "0x1C1E610", VA = "0x1C1E610")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
