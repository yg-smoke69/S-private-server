using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167A")]
public class CSGetIPTagConfigRes
{
	[Token(Token = "0x4009643")]
	[FieldOffset(Offset = "0x8")]
	public List<IPTagConfigDesc> ip_tag_config;

	[Token(Token = "0x6007CC4")]
	[Address(RVA = "0x3186144", Offset = "0x3186144", VA = "0x3186144")]
	public CSGetIPTagConfigRes()
	{
	}
}
