using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001814")]
public class CSGetGoliathSettingRes
{
	[Token(Token = "0x4009C02")]
	[FieldOffset(Offset = "0x8")]
	public GoliathSettingDesc desc;

	[Token(Token = "0x4009C03")]
	[FieldOffset(Offset = "0xC")]
	public List<GoliathAFKTaskDesc> task_list;

	[Token(Token = "0x6007E6E")]
	[Address(RVA = "0x3185BB0", Offset = "0x3185BB0", VA = "0x3185BB0")]
	public CSGetGoliathSettingRes()
	{
	}
}
