using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200301F")]
public class ChallengesUpdateInfo
{
	[Token(Token = "0x401253D")]
	[FieldOffset(Offset = "0x8")]
	public uint status;

	[Token(Token = "0x401253E")]
	[FieldOffset(Offset = "0xC")]
	public uint currentValue;

	[Token(Token = "0x401253F")]
	[FieldOffset(Offset = "0x10")]
	public uint currentValue2;

	[Token(Token = "0x4012540")]
	[FieldOffset(Offset = "0x14")]
	public uint beforeValue;

	[Token(Token = "0x4012541")]
	[FieldOffset(Offset = "0x18")]
	public uint beforeValue2;

	[Token(Token = "0x4012542")]
	[FieldOffset(Offset = "0x1C")]
	public int targetValue;

	[Token(Token = "0x4012543")]
	[FieldOffset(Offset = "0x20")]
	public int targetValue2;

	[Token(Token = "0x4012544")]
	[FieldOffset(Offset = "0x24")]
	public string challengeDesc;

	[Token(Token = "0x4012545")]
	[FieldOffset(Offset = "0x28")]
	public byte countType;

	[Token(Token = "0x4012546")]
	[FieldOffset(Offset = "0x29")]
	public byte displayType;

	[Token(Token = "0x4012547")]
	[FieldOffset(Offset = "0x2A")]
	public bool isTeamWork;

	[Token(Token = "0x4012548")]
	[FieldOffset(Offset = "0x2B")]
	public bool needTransTime;

	[Token(Token = "0x4012549")]
	[FieldOffset(Offset = "0x2C")]
	public bool needTransTime2;

	[Token(Token = "0x6014232")]
	[Address(RVA = "0x17223D0", Offset = "0x17223D0", VA = "0x17223D0")]
	public ChallengesUpdateInfo(uint status, uint currentValue, uint currentValue2, uint beforeValue, uint beforeValue2, int targetValue, int targetValue2, string challengeDesc, byte countType, byte displayType, bool isTeamWork, bool needTransTime, bool needTransTime2)
	{
	}
}
