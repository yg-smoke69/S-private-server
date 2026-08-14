using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E53")]
public class AutoTaskCredit : AutoPopupTask
{
	[Token(Token = "0x400BF33")]
	[FieldOffset(Offset = "0x8")]
	private UICreditVerifyController m_UICreditVerifyController;

	[Token(Token = "0x60091B5")]
	[Address(RVA = "0x10F0084", Offset = "0x10F0084", VA = "0x10F0084")]
	public AutoTaskCredit()
	{
	}

	[Token(Token = "0x60091B6")]
	[Address(RVA = "0x10F008C", Offset = "0x10F008C", VA = "0x10F008C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091B7")]
	[Address(RVA = "0x10F0B38", Offset = "0x10F0B38", VA = "0x10F0B38", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x60091B8")]
	[Address(RVA = "0x10F0C38", Offset = "0x10F0C38", VA = "0x10F0C38", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
