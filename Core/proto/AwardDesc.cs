using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B4")]
public class AwardDesc
{
	[Token(Token = "0x400A116")]
	[FieldOffset(Offset = "0x8")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A117")]
	[FieldOffset(Offset = "0xC")]
	public uint award_id;

	[Token(Token = "0x400A118")]
	[FieldOffset(Offset = "0x10")]
	public uint award_num;

	[Token(Token = "0x400A119")]
	[FieldOffset(Offset = "0x14")]
	public uint award_max_num;

	[Token(Token = "0x400A11A")]
	[FieldOffset(Offset = "0x18")]
	public uint award_expire_time;

	[Token(Token = "0x600800B")]
	[Address(RVA = "0x317B404", Offset = "0x317B404", VA = "0x317B404")]
	public AwardDesc()
	{
	}

	[Token(Token = "0x600800C")]
	[Address(RVA = "0x317B40C", Offset = "0x317B40C", VA = "0x317B40C")]
	public AwardDesc Clone()
	{
		return null;
	}
}
