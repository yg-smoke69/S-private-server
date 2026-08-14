using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E64")]
public class AutoTaskLeveUp : AutoPopupTask
{
	[Token(Token = "0x400BF56")]
	[FieldOffset(Offset = "0x8")]
	private UILevelUpController m_LeveupWnd;

	[Token(Token = "0x6009202")]
	[Address(RVA = "0x10F6394", Offset = "0x10F6394", VA = "0x10F6394")]
	public AutoTaskLeveUp()
	{
	}

	[Token(Token = "0x6009203")]
	[Address(RVA = "0x10F639C", Offset = "0x10F639C", VA = "0x10F639C", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009204")]
	[Address(RVA = "0x10F63F4", Offset = "0x10F63F4", VA = "0x10F63F4", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009205")]
	[Address(RVA = "0x10F6808", Offset = "0x10F6808", VA = "0x10F6808")]
	public void UpdateGuesetBindAccountKeyIfNeeded(MatchIncome incomeData)
	{
	}

	[Token(Token = "0x6009206")]
	[Address(RVA = "0x10F6B3C", Offset = "0x10F6B3C", VA = "0x10F6B3C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
