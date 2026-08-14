using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DCB")]
internal class EPAwardInfo
{
	[Token(Token = "0x4011960")]
	[FieldOffset(Offset = "0x8")]
	public EPUnlockData unlockData;

	[Token(Token = "0x4011961")]
	[FieldOffset(Offset = "0xC")]
	public EPTarget_Status FPStatus;

	[Token(Token = "0x4011962")]
	[FieldOffset(Offset = "0x10")]
	public EPTarget_Status EPStatus;

	[Token(Token = "0x4011963")]
	[FieldOffset(Offset = "0x14")]
	public EPMaxAwardInfoType maxAwardType;

	[Token(Token = "0x601334D")]
	[Address(RVA = "0x1C9A54C", Offset = "0x1C9A54C", VA = "0x1C9A54C")]
	public EPAwardInfo(EPUnlockData data)
	{
	}

	[Token(Token = "0x601334E")]
	[Address(RVA = "0x1C9A57C", Offset = "0x1C9A57C", VA = "0x1C9A57C")]
	public EPAwardInfo(EPMaxAwardInfoType type)
	{
	}

	[Token(Token = "0x601334F")]
	[Address(RVA = "0x1C9A5A4", Offset = "0x1C9A5A4", VA = "0x1C9A5A4")]
	public bool hasNewReward()
	{
		return default(bool);
	}
}
