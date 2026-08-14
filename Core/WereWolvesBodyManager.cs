using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

[Token(Token = "0x2000744")]
internal class WereWolvesBodyManager
{
	[Token(Token = "0x4004CD4")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, LevelWereWolvesBody> m_BodysMap;

	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x2A6CA20", Offset = "0x2A6CA20", VA = "0x2A6CA20")]
	public WereWolvesBodyManager()
	{
	}

	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x2A6CAAC", Offset = "0x2A6CAAC", VA = "0x2A6CAAC")]
	public void CreateBody(BDDLLGKDNOG bodyInfo)
	{
	}

	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x2A6CDF8", Offset = "0x2A6CDF8", VA = "0x2A6CDF8")]
	public void DelBody(int bodyID)
	{
	}
}
