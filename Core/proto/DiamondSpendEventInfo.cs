using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015BD")]
public class DiamondSpendEventInfo
{
	[Token(Token = "0x400942C")]
	[FieldOffset(Offset = "0x8")]
	public List<DiamondSpendEventDesc> descs;

	[Token(Token = "0x400942D")]
	[FieldOffset(Offset = "0xC")]
	public uint topup_times;

	[Token(Token = "0x6007C07")]
	[Address(RVA = "0x309E820", Offset = "0x309E820", VA = "0x309E820")]
	public DiamondSpendEventInfo()
	{
	}
}
