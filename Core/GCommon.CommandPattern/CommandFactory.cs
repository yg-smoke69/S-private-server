using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E79")]
public class CommandFactory
{
	[Token(Token = "0x401A6A1")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, CommandPool> m_CommandPoolMap;

	[Token(Token = "0x60196E0")]
	[Address(RVA = "0x3086278", Offset = "0x3086278", VA = "0x3086278")]
	public CommandFactory()
	{
	}

	[Token(Token = "0x60196E1")]
	public T CreateCommand<T>() where T : Command, new()
	{
		return null;
	}

	[Token(Token = "0x60196E2")]
	public void ReleaseCommand<T>(T command) where T : Command
	{
	}

	[Token(Token = "0x60196E3")]
	[Address(RVA = "0x3086304", Offset = "0x3086304", VA = "0x3086304")]
	public void Clear(string typeFullName)
	{
	}

	[Token(Token = "0x60196E4")]
	[Address(RVA = "0x3086440", Offset = "0x3086440", VA = "0x3086440")]
	public void ClearAll()
	{
	}
}
