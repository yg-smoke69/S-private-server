using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F7")]
public class CSGetCollectTokenInfoRes
{
	[Token(Token = "0x4009BC7")]
	[FieldOffset(Offset = "0x8")]
	public List<LdcpTokenDesc> desc;

	[Token(Token = "0x4009BC8")]
	[FieldOffset(Offset = "0xC")]
	public uint collected_tokens;

	[Token(Token = "0x6007E51")]
	[Address(RVA = "0x3183328", Offset = "0x3183328", VA = "0x3183328")]
	public CSGetCollectTokenInfoRes()
	{
	}
}
