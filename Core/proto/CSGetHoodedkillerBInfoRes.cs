using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200183B")]
public class CSGetHoodedkillerBInfoRes
{
	[Token(Token = "0x4009C69")]
	[FieldOffset(Offset = "0x8")]
	public List<HoodedkillerBAssassinateInfo> assassinate_infos;

	[Token(Token = "0x6007E95")]
	[Address(RVA = "0x3185CE0", Offset = "0x3185CE0", VA = "0x3185CE0")]
	public CSGetHoodedkillerBInfoRes()
	{
	}
}
