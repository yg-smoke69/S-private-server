using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001770")]
public class CSGetLiveTableNamesRes
{
	[Token(Token = "0x4009A4A")]
	[FieldOffset(Offset = "0x8")]
	public List<LiveTableNameDesc> live_table_name_list;

	[Token(Token = "0x6007DCA")]
	[Address(RVA = "0x318717C", Offset = "0x318717C", VA = "0x318717C")]
	public CSGetLiveTableNamesRes()
	{
	}
}
