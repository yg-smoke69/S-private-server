using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000098")]
public class AgeVerifiedManager
{
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, uint> m_Age;

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x14C3048", Offset = "0x14C3048", VA = "0x14C3048")]
	public AgeVerifiedManager()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x14C333C", Offset = "0x14C333C", VA = "0x14C333C")]
	public uint GetAge(string country)
	{
		return default(uint);
	}
}
