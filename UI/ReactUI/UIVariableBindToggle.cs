using Il2CppDummyDll;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CDF")]
public sealed class UIVariableBindToggle : UIVariableBindBool
{
	[Token(Token = "0x4006850")]
	[FieldOffset(Offset = "0x28")]
	private Toggle m_toggle;

	[Token(Token = "0x60061AF")]
	[Address(RVA = "0x31692B8", Offset = "0x31692B8", VA = "0x31692B8")]
	public UIVariableBindToggle()
	{
	}

	[Token(Token = "0x60061B0")]
	[Address(RVA = "0x31692BC", Offset = "0x31692BC", VA = "0x31692BC", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
