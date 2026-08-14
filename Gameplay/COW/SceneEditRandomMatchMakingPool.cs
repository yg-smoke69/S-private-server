using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003226")]
public class SceneEditRandomMatchMakingPool
{
	[Token(Token = "0x4013151")]
	[FieldOffset(Offset = "0x8")]
	private List<string> codePool;

	[Token(Token = "0x4013152")]
	[FieldOffset(Offset = "0xC")]
	private uint GroupMode;

	[Token(Token = "0x601522F")]
	[Address(RVA = "0x242142C", Offset = "0x242142C", VA = "0x242142C")]
	public SceneEditRandomMatchMakingPool()
	{
	}
}
