using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F2F")]
public class ConditionActionManager
{
	[Token(Token = "0x401AA37")]
	[FieldOffset(Offset = "0x8")]
	private ObjectPool<ConditionAction> m_conditionActionPool;

	[Token(Token = "0x401AA38")]
	[FieldOffset(Offset = "0xC")]
	private List<ConditionAction> m_condtionActions;

	[Token(Token = "0x6019B7B")]
	[Address(RVA = "0x307AA00", Offset = "0x307AA00", VA = "0x307AA00")]
	public ConditionActionManager()
	{
	}

	[Token(Token = "0x6019B7C")]
	[Address(RVA = "0x307C55C", Offset = "0x307C55C", VA = "0x307C55C")]
	public ConditionAction Add()
	{
		return null;
	}

	[Token(Token = "0x6019B7D")]
	[Address(RVA = "0x307C644", Offset = "0x307C644", VA = "0x307C644")]
	public void CancelConditionAction(int guid)
	{
	}

	[Token(Token = "0x6019B7E")]
	[Address(RVA = "0x307B75C", Offset = "0x307B75C", VA = "0x307B75C")]
	public void RunOneFrame()
	{
	}

	[Token(Token = "0x6019B7F")]
	[Address(RVA = "0x307BEC8", Offset = "0x307BEC8", VA = "0x307BEC8")]
	public void Clear()
	{
	}
}
