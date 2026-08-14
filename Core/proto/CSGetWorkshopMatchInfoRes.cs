using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018F8")]
public class CSGetWorkshopMatchInfoRes
{
	[Token(Token = "0x4009E50")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x4009E51")]
	[FieldOffset(Offset = "0xC")]
	public List<string> workshop_codes;

	[Token(Token = "0x4009E52")]
	[FieldOffset(Offset = "0x10")]
	public bool is_workshop_team_contest;

	[Token(Token = "0x4009E53")]
	[FieldOffset(Offset = "0x14")]
	public uint[] workshop_team_counts;

	[Token(Token = "0x6007F51")]
	[Address(RVA = "0x3096DE0", Offset = "0x3096DE0", VA = "0x3096DE0")]
	public CSGetWorkshopMatchInfoRes()
	{
	}
}
