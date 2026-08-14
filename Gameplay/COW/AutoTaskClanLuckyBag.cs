using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002535")]
public class AutoTaskClanLuckyBag : AutoPopupTask
{
	[Token(Token = "0x400E695")]
	[FieldOffset(Offset = "0x8")]
	private UILuckyBagController m_LuckyBagUI;

	[Token(Token = "0x600D873")]
	[Address(RVA = "0x10EEFE4", Offset = "0x10EEFE4", VA = "0x10EEFE4")]
	public AutoTaskClanLuckyBag()
	{
	}

	[Token(Token = "0x600D874")]
	[Address(RVA = "0x10EEFEC", Offset = "0x10EEFEC", VA = "0x10EEFEC", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600D875")]
	[Address(RVA = "0x10EF28C", Offset = "0x10EF28C", VA = "0x10EF28C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600D876")]
	[Address(RVA = "0x10EF38C", Offset = "0x10EF38C", VA = "0x10EF38C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
