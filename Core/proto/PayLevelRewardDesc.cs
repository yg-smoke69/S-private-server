using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC4")]
public class PayLevelRewardDesc
{
	[Token(Token = "0x400A88F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A890")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x400A891")]
	[FieldOffset(Offset = "0x10")]
	public EStore.PayLevelRewardHintType hint;

	[Token(Token = "0x400A892")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x6008121")]
	[Address(RVA = "0x33DF230", Offset = "0x33DF230", VA = "0x33DF230")]
	public PayLevelRewardDesc()
	{
	}
}
