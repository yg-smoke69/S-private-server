using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F2")]
public class UIHudPVETurnInfoView : UIBaseView
{
	[Token(Token = "0x401632A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TurnTxt;

	[Token(Token = "0x401632B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MidTurnInfo;

	[Token(Token = "0x401632C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MidTurnTxt;

	[Token(Token = "0x6016881")]
	[Address(RVA = "0x183DB08", Offset = "0x183DB08", VA = "0x183DB08")]
	public UIHudPVETurnInfoView()
	{
	}

	[Token(Token = "0x6016882")]
	[Address(RVA = "0x183DB10", Offset = "0x183DB10", VA = "0x183DB10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016883")]
	[Address(RVA = "0x183DD6C", Offset = "0x183DD6C", VA = "0x183DD6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
