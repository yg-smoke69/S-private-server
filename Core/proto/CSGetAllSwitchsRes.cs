using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001716")]
public class CSGetAllSwitchsRes
{
	[Token(Token = "0x400986F")]
	[FieldOffset(Offset = "0x8")]
	public List<SwitchDesc> switchs;

	[Token(Token = "0x6007D70")]
	[Address(RVA = "0x3181840", Offset = "0x3181840", VA = "0x3181840")]
	public CSGetAllSwitchsRes()
	{
	}
}
