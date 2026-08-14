using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A6")]
public class UIHudManualTipsView : UIBaseView
{
	[Token(Token = "0x401600D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x401600E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Message;

	[Token(Token = "0x601679F")]
	[Address(RVA = "0xFF9894", Offset = "0xFF9894", VA = "0xFF9894")]
	public UIHudManualTipsView()
	{
	}

	[Token(Token = "0x60167A0")]
	[Address(RVA = "0xFF989C", Offset = "0xFF989C", VA = "0xFF989C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167A1")]
	[Address(RVA = "0xFF9A98", Offset = "0xFF9A98", VA = "0xFF9A98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
