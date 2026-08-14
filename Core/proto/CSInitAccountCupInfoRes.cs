using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001570")]
public class CSInitAccountCupInfoRes
{
	[Token(Token = "0x4009329")]
	[FieldOffset(Offset = "0x8")]
	public List<CSAccountCupInfoRes> infos;

	[Token(Token = "0x6007BB8")]
	[Address(RVA = "0x309737C", Offset = "0x309737C", VA = "0x309737C")]
	public CSInitAccountCupInfoRes()
	{
	}
}
