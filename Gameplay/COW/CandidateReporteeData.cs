using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003167")]
public class CandidateReporteeData
{
	[Token(Token = "0x4012C29")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4012C2A")]
	[FieldOffset(Offset = "0x10")]
	public ulong uID;

	[Token(Token = "0x4012C2B")]
	[FieldOffset(Offset = "0x18")]
	public IHAAMHPPLMG playerID;

	[Token(Token = "0x4012C2C")]
	[FieldOffset(Offset = "0x30")]
	public CandidateReporteeType type;

	[Token(Token = "0x6014B75")]
	[Address(RVA = "0x1721350", Offset = "0x1721350", VA = "0x1721350")]
	public CandidateReporteeData(string name, ulong uID, IHAAMHPPLMG playerID, CandidateReporteeType type)
	{
	}
}
