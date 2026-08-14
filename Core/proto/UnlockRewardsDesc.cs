using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8D")]
public class UnlockRewardsDesc
{
	[Token(Token = "0x400A638")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A639")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_id;

	[Token(Token = "0x400A63A")]
	[FieldOffset(Offset = "0x10")]
	public uint require_item;

	[Token(Token = "0x400A63B")]
	[FieldOffset(Offset = "0x14")]
	public uint require_num;

	[Token(Token = "0x400A63C")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType fp_award_type;

	[Token(Token = "0x400A63D")]
	[FieldOffset(Offset = "0x1C")]
	public uint fp_award_id;

	[Token(Token = "0x400A63E")]
	[FieldOffset(Offset = "0x20")]
	public uint fp_award_num;

	[Token(Token = "0x400A63F")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.AwardType ep_award_type;

	[Token(Token = "0x400A640")]
	[FieldOffset(Offset = "0x28")]
	public uint ep_award_id;

	[Token(Token = "0x400A641")]
	[FieldOffset(Offset = "0x2C")]
	public uint ep_award_num;

	[Token(Token = "0x400A642")]
	[FieldOffset(Offset = "0x30")]
	public uint fp_award_time;

	[Token(Token = "0x400A643")]
	[FieldOffset(Offset = "0x34")]
	public uint ep_award_time;

	[Token(Token = "0x60080EA")]
	[Address(RVA = "0x33E41B0", Offset = "0x33E41B0", VA = "0x33E41B0")]
	public UnlockRewardsDesc()
	{
	}
}
