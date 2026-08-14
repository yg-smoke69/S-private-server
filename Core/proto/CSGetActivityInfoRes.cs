using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001607")]
public class CSGetActivityInfoRes
{
	[Token(Token = "0x40094DB")]
	[FieldOffset(Offset = "0x8")]
	public List<ActivityInfo> activitys;

	[Token(Token = "0x6007C51")]
	[Address(RVA = "0x3181228", Offset = "0x3181228", VA = "0x3181228")]
	public CSGetActivityInfoRes()
	{
	}
}
