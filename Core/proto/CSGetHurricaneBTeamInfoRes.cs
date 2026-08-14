using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001951")]
public class CSGetHurricaneBTeamInfoRes
{
	[Token(Token = "0x4009F6C")]
	[FieldOffset(Offset = "0x8")]
	public List<HurricaneBTeamMemberInfo> members;

	[Token(Token = "0x4009F6D")]
	[FieldOffset(Offset = "0xC")]
	public uint member_count;

	[Token(Token = "0x4009F6E")]
	[FieldOffset(Offset = "0x10")]
	public uint team_process;

	[Token(Token = "0x4009F6F")]
	[FieldOffset(Offset = "0x14")]
	public uint claimed_process;

	[Token(Token = "0x6007FAA")]
	[Address(RVA = "0x3185F5C", Offset = "0x3185F5C", VA = "0x3185F5C")]
	public CSGetHurricaneBTeamInfoRes()
	{
	}
}
