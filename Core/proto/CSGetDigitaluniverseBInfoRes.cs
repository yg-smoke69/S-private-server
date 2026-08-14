using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200195F")]
public class CSGetDigitaluniverseBInfoRes
{
	[Token(Token = "0x4009F92")]
	[FieldOffset(Offset = "0x8")]
	public uint charactergate_story_group_id;

	[Token(Token = "0x4009F93")]
	[FieldOffset(Offset = "0xC")]
	public uint charactergate_mission_progress;

	[Token(Token = "0x4009F94")]
	[FieldOffset(Offset = "0x10")]
	public uint[] charactergate_claimed_award;

	[Token(Token = "0x4009F95")]
	[FieldOffset(Offset = "0x18")]
	public long time_attack_expire_at;

	[Token(Token = "0x4009F96")]
	[FieldOffset(Offset = "0x20")]
	public ELimitedEvent.DigitaluniverseBTimeAttackStatus time_attack_status;

	[Token(Token = "0x4009F97")]
	[FieldOffset(Offset = "0x24")]
	public uint eventgate_mission_progress;

	[Token(Token = "0x4009F98")]
	[FieldOffset(Offset = "0x28")]
	public uint[] eventgate_claimed_award;

	[Token(Token = "0x4009F99")]
	[FieldOffset(Offset = "0x2C")]
	public uint collectiongate_mission_progress;

	[Token(Token = "0x4009F9A")]
	[FieldOffset(Offset = "0x30")]
	public uint[] collectiongate_claimed_award;

	[Token(Token = "0x4009F9B")]
	[FieldOffset(Offset = "0x34")]
	public uint clothgate_mission_progress;

	[Token(Token = "0x4009F9C")]
	[FieldOffset(Offset = "0x38")]
	public uint[] clothgate_claimed_award;

	[Token(Token = "0x4009F9D")]
	[FieldOffset(Offset = "0x3C")]
	public uint mapgate_mission_progress;

	[Token(Token = "0x4009F9E")]
	[FieldOffset(Offset = "0x40")]
	public uint[] mapgate_claimed_award;

	[Token(Token = "0x6007FB8")]
	[Address(RVA = "0x3183DC4", Offset = "0x3183DC4", VA = "0x3183DC4")]
	public CSGetDigitaluniverseBInfoRes()
	{
	}
}
