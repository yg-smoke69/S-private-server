using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F4")]
public class CSGetWorkshopHistoryInfoRes
{
	[Token(Token = "0x4009E45")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopHistoryInfo> history_infos;

	[Token(Token = "0x6007F4D")]
	[Address(RVA = "0x3096CC0", Offset = "0x3096CC0", VA = "0x3096CC0")]
	public CSGetWorkshopHistoryInfoRes()
	{
	}
}
