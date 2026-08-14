using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CD1")]
public sealed class UIVariableBindImageBool : UIVariableBindBool
{
	[Token(Token = "0x40067FE")]
	[FieldOffset(Offset = "0x28")]
	public string spriteNameIfTrue;

	[Token(Token = "0x40067FF")]
	[FieldOffset(Offset = "0x2C")]
	public string spriteNameIfFalse;

	[Token(Token = "0x4006800")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_image;

	[Token(Token = "0x6006169")]
	[Address(RVA = "0x31639DC", Offset = "0x31639DC", VA = "0x31639DC")]
	public UIVariableBindImageBool()
	{
	}

	[Token(Token = "0x600616A")]
	[Address(RVA = "0x31639E0", Offset = "0x31639E0", VA = "0x31639E0", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
