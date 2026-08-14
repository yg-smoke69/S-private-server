using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015BE")]
public class CSTopupEventInfoRes
{
	[Token(Token = "0x400942E")]
	[FieldOffset(Offset = "0x8")]
	public MysteryBonusInfo mystery_bonus;

	[Token(Token = "0x400942F")]
	[FieldOffset(Offset = "0xC")]
	public DiamondSpendEventInfo diamond_spend_event;

	[Token(Token = "0x6007C08")]
	[Address(RVA = "0x309A484", Offset = "0x309A484", VA = "0x309A484")]
	public CSTopupEventInfoRes()
	{
	}
}
