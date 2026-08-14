using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CC4")]
public sealed class UIVariableBindColor : UIVariableBindBool
{
	[Token(Token = "0x40067B8")]
	[FieldOffset(Offset = "0x28")]
	private Color enabledColor;

	[Token(Token = "0x40067B9")]
	[FieldOffset(Offset = "0x38")]
	private Color disabledColor;

	[Token(Token = "0x40067BA")]
	[FieldOffset(Offset = "0x48")]
	private Graphic m_graphic;

	[Token(Token = "0x40067BB")]
	[FieldOffset(Offset = "0x4C")]
	private Shadow m_shadow;

	[Token(Token = "0x40067BC")]
	[FieldOffset(Offset = "0x50")]
	private Color m_currentColor;

	[Token(Token = "0x6006130")]
	[Address(RVA = "0x315EF98", Offset = "0x315EF98", VA = "0x315EF98")]
	public UIVariableBindColor()
	{
	}

	[Token(Token = "0x6006131")]
	[Address(RVA = "0x315EFF4", Offset = "0x315EFF4", VA = "0x315EFF4", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
