using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D4")]
public class UIHudPartySpeedDownView : UIBaseView
{
	[Token(Token = "0x4016231")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSpeed;

	[Token(Token = "0x6016829")]
	[Address(RVA = "0x1846870", Offset = "0x1846870", VA = "0x1846870")]
	public UIHudPartySpeedDownView()
	{
	}

	[Token(Token = "0x601682A")]
	[Address(RVA = "0x1846878", Offset = "0x1846878", VA = "0x1846878", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601682B")]
	[Address(RVA = "0x1846A20", Offset = "0x1846A20", VA = "0x1846A20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
