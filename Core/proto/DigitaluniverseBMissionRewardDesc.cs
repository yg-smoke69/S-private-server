using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B64")]
public class DigitaluniverseBMissionRewardDesc
{
	[Token(Token = "0x400AC5B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC5C")]
	[FieldOffset(Offset = "0xC")]
	public uint progress;

	[Token(Token = "0x400AC5D")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x400AC5E")]
	[FieldOffset(Offset = "0x14")]
	public ELimitedEvent.DigitaluniverseBGateType gate_type;

	[Token(Token = "0x60081BF")]
	[Address(RVA = "0x309EAD0", Offset = "0x309EAD0", VA = "0x309EAD0")]
	public DigitaluniverseBMissionRewardDesc()
	{
	}
}
