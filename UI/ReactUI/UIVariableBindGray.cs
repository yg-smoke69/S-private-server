using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CC9")]
public sealed class UIVariableBindGray : UIVariableBindBool
{
	[Token(Token = "0x40067DB")]
	[FieldOffset(Offset = "0x28")]
	private int enabledGray;

	[Token(Token = "0x40067DC")]
	[FieldOffset(Offset = "0x2C")]
	private int disabledGray;

	[Token(Token = "0x6006155")]
	[Address(RVA = "0x3160B80", Offset = "0x3160B80", VA = "0x3160B80")]
	public UIVariableBindGray()
	{
	}

	[Token(Token = "0x6006156")]
	[Address(RVA = "0x3160B8C", Offset = "0x3160B8C", VA = "0x3160B8C", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
