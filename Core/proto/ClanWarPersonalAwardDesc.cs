using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A37")]
public class ClanWarPersonalAwardDesc
{
	[Token(Token = "0x400A424")]
	[FieldOffset(Offset = "0x8")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600808F")]
	[Address(RVA = "0x309C3B8", Offset = "0x309C3B8", VA = "0x309C3B8")]
	public ClanWarPersonalAwardDesc()
	{
	}
}
