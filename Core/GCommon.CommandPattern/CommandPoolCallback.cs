using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E7D")]
public class CommandPoolCallback : ObjectPoolCallbackBase
{
	[Token(Token = "0x401A6AC")]
	[FieldOffset(Offset = "0xC")]
	protected CommandPool m_Pool;

	[Token(Token = "0x60196F9")]
	[Address(RVA = "0x3086260", Offset = "0x3086260", VA = "0x3086260")]
	public CommandPoolCallback()
	{
	}

	[Token(Token = "0x60196FA")]
	[Address(RVA = "0x3086FB0", Offset = "0x3086FB0", VA = "0x3086FB0", Slot = "10")]
	public virtual void SetPool(CommandPool pool)
	{
	}

	[Token(Token = "0x60196FB")]
	[Address(RVA = "0x3086FB8", Offset = "0x3086FB8", VA = "0x3086FB8", Slot = "11")]
	public virtual void CollectSelf()
	{
	}
}
