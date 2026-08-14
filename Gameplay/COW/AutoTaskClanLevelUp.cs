using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002536")]
public class AutoTaskClanLevelUp : AutoPopupTask
{
	[Token(Token = "0x400E696")]
	[FieldOffset(Offset = "0x8")]
	private UIClanLevelUpController m_LevelUpUI;

	[Token(Token = "0x600D877")]
	[Address(RVA = "0x10EEAFC", Offset = "0x10EEAFC", VA = "0x10EEAFC")]
	public AutoTaskClanLevelUp()
	{
	}

	[Token(Token = "0x600D878")]
	[Address(RVA = "0x10EEB04", Offset = "0x10EEB04", VA = "0x10EEB04", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600D879")]
	[Address(RVA = "0x10EEE8C", Offset = "0x10EEE8C", VA = "0x10EEE8C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600D87A")]
	[Address(RVA = "0x10EEF8C", Offset = "0x10EEF8C", VA = "0x10EEF8C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
