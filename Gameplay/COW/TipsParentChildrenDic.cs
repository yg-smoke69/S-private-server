using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D47")]
public class TipsParentChildrenDic
{
	[Token(Token = "0x40115E5")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> m_TipsChildParentDic;

	[Token(Token = "0x6012F40")]
	[Address(RVA = "0x28ABB48", Offset = "0x28ABB48", VA = "0x28ABB48")]
	public TipsParentChildrenDic()
	{
	}

	[Token(Token = "0x6012F41")]
	[Address(RVA = "0x28AA89C", Offset = "0x28AA89C", VA = "0x28AA89C")]
	public static List<int> GetChildType(ETipsType parent)
	{
		return null;
	}

	[Token(Token = "0x6012F42")]
	[Address(RVA = "0x28AB4D4", Offset = "0x28AB4D4", VA = "0x28AB4D4")]
	public static ETipsType GetParentType(ETipsType child)
	{
		return default(ETipsType);
	}
}
