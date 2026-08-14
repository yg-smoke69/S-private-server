using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8E")]
public class PreorderSettingDesc
{
	[Token(Token = "0x400A644")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_id;

	[Token(Token = "0x400A645")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x400A646")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A647")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A648")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType extra_award_type1;

	[Token(Token = "0x400A649")]
	[FieldOffset(Offset = "0x1C")]
	public uint extra_award_id1;

	[Token(Token = "0x400A64A")]
	[FieldOffset(Offset = "0x20")]
	public uint extra_award_num1;

	[Token(Token = "0x400A64B")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.AwardType extra_award_type2;

	[Token(Token = "0x400A64C")]
	[FieldOffset(Offset = "0x28")]
	public uint extra_award_id2;

	[Token(Token = "0x400A64D")]
	[FieldOffset(Offset = "0x2C")]
	public uint extra_award_num2;

	[Token(Token = "0x400A64E")]
	[FieldOffset(Offset = "0x30")]
	public long start_timestamp;

	[Token(Token = "0x400A64F")]
	[FieldOffset(Offset = "0x38")]
	public long end_timestamp;

	[Token(Token = "0x400A650")]
	[FieldOffset(Offset = "0x40")]
	public long subscription_start_time;

	[Token(Token = "0x400A651")]
	[FieldOffset(Offset = "0x48")]
	public long subscription_end_time;

	[Token(Token = "0x400A652")]
	[FieldOffset(Offset = "0x50")]
	public uint award_time1;

	[Token(Token = "0x400A653")]
	[FieldOffset(Offset = "0x54")]
	public uint award_time2;

	[Token(Token = "0x60080EB")]
	[Address(RVA = "0x33E00AC", Offset = "0x33E00AC", VA = "0x33E00AC")]
	public PreorderSettingDesc()
	{
	}
}
