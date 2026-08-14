using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E6")]
public class ModeLevelLimitDescList
{
	[Token(Token = "0x400A2B0")]
	[FieldOffset(Offset = "0x8")]
	public List<ModeLevelLimitDesc> mode_level_limits;

	[Token(Token = "0x600803E")]
	[Address(RVA = "0x30A8C68", Offset = "0x30A8C68", VA = "0x30A8C68")]
	public ModeLevelLimitDescList()
	{
	}
}
