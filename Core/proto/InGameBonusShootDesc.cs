using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B8")]
public class InGameBonusShootDesc
{
	[Token(Token = "0x400A12D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A12E")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x400A12F")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A130")]
	[FieldOffset(Offset = "0x14")]
	public uint award_id;

	[Token(Token = "0x400A131")]
	[FieldOffset(Offset = "0x18")]
	public uint award_num;

	[Token(Token = "0x400A132")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_time;

	[Token(Token = "0x400A133")]
	[FieldOffset(Offset = "0x20")]
	public bool is_lucky;

	[Token(Token = "0x400A134")]
	[FieldOffset(Offset = "0x21")]
	public bool is_preview_probability;

	[Token(Token = "0x6008010")]
	[Address(RVA = "0x30A3C60", Offset = "0x30A3C60", VA = "0x30A3C60")]
	public InGameBonusShootDesc()
	{
	}
}
