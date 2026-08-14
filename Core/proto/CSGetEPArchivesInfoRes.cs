using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001711")]
public class CSGetEPArchivesInfoRes
{
	[Token(Token = "0x4009869")]
	[FieldOffset(Offset = "0x8")]
	public List<EPArchiveInfo> ep_archives_info;

	[Token(Token = "0x6007D6B")]
	[Address(RVA = "0x31842F4", Offset = "0x31842F4", VA = "0x31842F4")]
	public CSGetEPArchivesInfoRes()
	{
	}
}
