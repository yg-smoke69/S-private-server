using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DCC")]
public class EPChallengeInfo
{
	[Token(Token = "0x4011964")]
	[FieldOffset(Offset = "0x8")]
	public EPChallengeData challengeData;

	[Token(Token = "0x4011965")]
	[FieldOffset(Offset = "0xC")]
	public ChallengeStatus status;

	[Token(Token = "0x4011966")]
	[FieldOffset(Offset = "0x10")]
	public bool isUnlocked;

	[Token(Token = "0x6013350")]
	[Address(RVA = "0x1C9C9E8", Offset = "0x1C9C9E8", VA = "0x1C9C9E8")]
	public EPChallengeInfo()
	{
	}
}
