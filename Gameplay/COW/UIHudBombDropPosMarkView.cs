using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F0")]
public class UIHudBombDropPosMarkView : UIBaseView
{
	[Token(Token = "0x4015980")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel RootPanel;

	[Token(Token = "0x4015981")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4015982")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015983")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015984")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ArrowRight;

	[Token(Token = "0x4015985")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4015986")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget boundWidget;

	[Token(Token = "0x601657E")]
	[Address(RVA = "0x1E0AEB8", Offset = "0x1E0AEB8", VA = "0x1E0AEB8")]
	public UIHudBombDropPosMarkView()
	{
	}

	[Token(Token = "0x601657F")]
	[Address(RVA = "0x1E0AEC0", Offset = "0x1E0AEC0", VA = "0x1E0AEC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016580")]
	[Address(RVA = "0x1E0B278", Offset = "0x1E0B278", VA = "0x1E0B278")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
