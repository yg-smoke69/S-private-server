using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015F1")]
public class CSGetNewPlayerLevelUpTaskInfoRes
{
	[Token(Token = "0x400949E")]
	[FieldOffset(Offset = "0x8")]
	public List<NewPlayerLevelUpTaskInfo> tasks;

	[Token(Token = "0x6007C3B")]
	[Address(RVA = "0x31880AC", Offset = "0x31880AC", VA = "0x31880AC")]
	public CSGetNewPlayerLevelUpTaskInfoRes()
	{
	}
}
