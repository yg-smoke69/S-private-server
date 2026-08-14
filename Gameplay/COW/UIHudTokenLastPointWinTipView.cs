using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003775")]
public class UIHudTokenLastPointWinTipView : UIBaseView
{
	[Token(Token = "0x4016774")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TipLabel;

	[Token(Token = "0x6016A0A")]
	[Address(RVA = "0x1582240", Offset = "0x1582240", VA = "0x1582240")]
	public UIHudTokenLastPointWinTipView()
	{
	}

	[Token(Token = "0x6016A0B")]
	[Address(RVA = "0x1582248", Offset = "0x1582248", VA = "0x1582248", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A0C")]
	[Address(RVA = "0x15823F0", Offset = "0x15823F0", VA = "0x15823F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
