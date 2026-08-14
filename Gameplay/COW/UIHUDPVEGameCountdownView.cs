using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036EF")]
public class UIHUDPVEGameCountdownView : UIBaseView
{
	[Token(Token = "0x4016325")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountDownLabel;

	[Token(Token = "0x6016878")]
	[Address(RVA = "0x1681E88", Offset = "0x1681E88", VA = "0x1681E88")]
	public UIHUDPVEGameCountdownView()
	{
	}

	[Token(Token = "0x6016879")]
	[Address(RVA = "0x1681E90", Offset = "0x1681E90", VA = "0x1681E90", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601687A")]
	[Address(RVA = "0x1682038", Offset = "0x1682038", VA = "0x1682038")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
