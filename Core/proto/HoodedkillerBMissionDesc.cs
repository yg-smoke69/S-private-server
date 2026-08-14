using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B5D")]
public class HoodedkillerBMissionDesc
{
	[Token(Token = "0x400AC2C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC2D")]
	[FieldOffset(Offset = "0xC")]
	public uint target_type;

	[Token(Token = "0x400AC2E")]
	[FieldOffset(Offset = "0x10")]
	public uint pre_target;

	[Token(Token = "0x400AC2F")]
	[FieldOffset(Offset = "0x14")]
	public uint related_activity_id;

	[Token(Token = "0x400AC30")]
	[FieldOffset(Offset = "0x18")]
	public uint basic_probability;

	[Token(Token = "0x400AC31")]
	[FieldOffset(Offset = "0x1C")]
	public uint sword_bonus_probability;

	[Token(Token = "0x400AC32")]
	[FieldOffset(Offset = "0x20")]
	public uint lower_floating_probability;

	[Token(Token = "0x400AC33")]
	[FieldOffset(Offset = "0x24")]
	public uint upper_floating_probability;

	[Token(Token = "0x400AC34")]
	[FieldOffset(Offset = "0x28")]
	public uint sleeve_arrow_token;

	[Token(Token = "0x400AC35")]
	[FieldOffset(Offset = "0x2C")]
	public uint sword_token;

	[Token(Token = "0x400AC36")]
	[FieldOffset(Offset = "0x30")]
	public uint failure_probability;

	[Token(Token = "0x400AC37")]
	[FieldOffset(Offset = "0x34")]
	public uint mission_probability;

	[Token(Token = "0x60081B8")]
	[Address(RVA = "0x30A3058", Offset = "0x30A3058", VA = "0x30A3058")]
	public HoodedkillerBMissionDesc()
	{
	}
}
