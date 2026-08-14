using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032FA")]
internal class UIFateRandomGameSubmode_Base
{
	[Token(Token = "0x40135FA")]
	[FieldOffset(Offset = "0x8")]
	protected UIFateRandomGameScene m_owner;

	[Token(Token = "0x60157D4")]
	[Address(RVA = "0x1DBD0BC", Offset = "0x1DBD0BC", VA = "0x1DBD0BC")]
	public UIFateRandomGameSubmode_Base()
	{
	}

	[Token(Token = "0x60157D5")]
	[Address(RVA = "0x1DBC79C", Offset = "0x1DBC79C", VA = "0x1DBC79C")]
	public void Init(UIFateRandomGameScene owner)
	{
	}

	[Token(Token = "0x60157D6")]
	[Address(RVA = "0x1DBD0C4", Offset = "0x1DBD0C4", VA = "0x1DBD0C4", Slot = "4")]
	public virtual void OpenCommonHud()
	{
	}

	[Token(Token = "0x60157D7")]
	[Address(RVA = "0x1DBD118", Offset = "0x1DBD118", VA = "0x1DBD118", Slot = "5")]
	public virtual void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60157D8")]
	[Address(RVA = "0x1DBD16C", Offset = "0x1DBD16C", VA = "0x1DBD16C", Slot = "6")]
	public virtual void OnDestory()
	{
	}
}
