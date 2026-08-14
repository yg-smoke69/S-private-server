using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D5")]
public class UIHudPartySpeedUpView : UIBaseView
{
	[Token(Token = "0x4016232")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSpeed;

	[Token(Token = "0x601682C")]
	[Address(RVA = "0x18472D4", Offset = "0x18472D4", VA = "0x18472D4")]
	public UIHudPartySpeedUpView()
	{
	}

	[Token(Token = "0x601682D")]
	[Address(RVA = "0x18472DC", Offset = "0x18472DC", VA = "0x18472DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601682E")]
	[Address(RVA = "0x1847484", Offset = "0x1847484", VA = "0x1847484")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
