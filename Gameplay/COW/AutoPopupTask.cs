using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E47")]
public abstract class AutoPopupTask
{
	[Token(Token = "0x6009182")]
	[Address(RVA = "0x10E7750", Offset = "0x10E7750", VA = "0x10E7750")]
	protected AutoPopupTask()
	{
	}

	[Token(Token = "0x6009183")]
	public abstract int[] NeedHttpRequests();

	[Token(Token = "0x6009184")]
	public abstract bool Do();

	[Token(Token = "0x6009185")]
	public abstract bool IsDone();
}
