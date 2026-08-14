using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CDB")]
public sealed class UIVariableBindScale : UIVariableBindBool
{
	[Token(Token = "0x400683C")]
	[FieldOffset(Offset = "0x28")]
	private float enabledScale;

	[Token(Token = "0x400683D")]
	[FieldOffset(Offset = "0x2C")]
	private float disabledScale;

	[Token(Token = "0x600619A")]
	[Address(RVA = "0x31673B8", Offset = "0x31673B8", VA = "0x31673B8")]
	public UIVariableBindScale()
	{
	}

	[Token(Token = "0x600619B")]
	[Address(RVA = "0x31673C4", Offset = "0x31673C4", VA = "0x31673C4", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
