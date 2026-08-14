using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F3")]
public class CSGetWorkshopLatestInfoRes
{
	[Token(Token = "0x4009E44")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopLatestInfo> latest_infos;

	[Token(Token = "0x6007F4C")]
	[Address(RVA = "0x3096D4C", Offset = "0x3096D4C", VA = "0x3096D4C")]
	public CSGetWorkshopLatestInfoRes()
	{
	}
}
