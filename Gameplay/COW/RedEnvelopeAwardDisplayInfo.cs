using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2003A8F")]
internal class RedEnvelopeAwardDisplayInfo
{
	[Token(Token = "0x4018E7F")]
	[FieldOffset(Offset = "0x8")]
	public string PlayerName;

	[Token(Token = "0x4018E80")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x4018E81")]
	[FieldOffset(Offset = "0x10")]
	public RedEnvelopeAwardType AwardType;

	[Token(Token = "0x4018E82")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardNum;

	[Token(Token = "0x4018E83")]
	[FieldOffset(Offset = "0x18")]
	public uint AwardTime;

	[Token(Token = "0x4018E84")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsLucky;

	[Token(Token = "0x6017353")]
	[Address(RVA = "0x1971594", Offset = "0x1971594", VA = "0x1971594")]
	public RedEnvelopeAwardDisplayInfo(PGNMHILNIDG awardInfo)
	{
	}

	[Token(Token = "0x6017354")]
	[Address(RVA = "0x1971658", Offset = "0x1971658", VA = "0x1971658")]
	public RedEnvelopeAwardDisplayInfo(ReceivedRedEnvelope awardInfo)
	{
	}
}
