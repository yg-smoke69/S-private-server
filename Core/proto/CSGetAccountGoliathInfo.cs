using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001817")]
public class CSGetAccountGoliathInfo
{
	[Token(Token = "0x4009C0D")]
	[FieldOffset(Offset = "0x8")]
	public List<GoliathAFKGroupInfo> group_list;

	[Token(Token = "0x4009C0E")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x6007E71")]
	[Address(RVA = "0x3180B90", Offset = "0x3180B90", VA = "0x3180B90")]
	public CSGetAccountGoliathInfo()
	{
	}
}
