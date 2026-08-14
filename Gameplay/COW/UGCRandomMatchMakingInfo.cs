using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003157")]
public class UGCRandomMatchMakingInfo
{
	[Token(Token = "0x4012BB6")]
	[FieldOffset(Offset = "0x8")]
	public List<string> CodePool;

	[Token(Token = "0x4012BB7")]
	[FieldOffset(Offset = "0xC")]
	public uint GroupMode;

	[Token(Token = "0x4012BB8")]
	[FieldOffset(Offset = "0x10")]
	public bool IsWorkshopTeamContest;

	[Token(Token = "0x4012BB9")]
	[FieldOffset(Offset = "0x14")]
	public uint[] WorkshopTeamCounts;

	[Token(Token = "0x6014AD3")]
	[Address(RVA = "0x29F4F98", Offset = "0x29F4F98", VA = "0x29F4F98")]
	public UGCRandomMatchMakingInfo()
	{
	}
}
