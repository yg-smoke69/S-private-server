using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AD")]
public class UICustomRoomCountDownWindowView : UIBaseView
{
	[Token(Token = "0x4014944")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountDownLabel;

	[Token(Token = "0x60161BB")]
	[Address(RVA = "0x11EC900", Offset = "0x11EC900", VA = "0x11EC900")]
	public UICustomRoomCountDownWindowView()
	{
	}

	[Token(Token = "0x60161BC")]
	[Address(RVA = "0x11EC908", Offset = "0x11EC908", VA = "0x11EC908", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161BD")]
	[Address(RVA = "0x11ECAB0", Offset = "0x11ECAB0", VA = "0x11ECAB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
