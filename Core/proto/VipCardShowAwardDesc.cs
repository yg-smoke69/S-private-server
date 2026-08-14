using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE1")]
public class VipCardShowAwardDesc
{
	[Token(Token = "0x400AF61")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF62")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600823C")]
	[Address(RVA = "0x33E4D7C", Offset = "0x33E4D7C", VA = "0x33E4D7C")]
	public VipCardShowAwardDesc()
	{
	}
}
