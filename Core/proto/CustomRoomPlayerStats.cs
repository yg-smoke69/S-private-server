using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200143B")]
public class CustomRoomPlayerStats
{
	[Token(Token = "0x4008CEB")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008CEC")]
	[FieldOffset(Offset = "0x10")]
	public uint kills;

	[Token(Token = "0x4008CED")]
	[FieldOffset(Offset = "0x14")]
	public uint headshot;

	[Token(Token = "0x4008CEE")]
	[FieldOffset(Offset = "0x18")]
	public uint damage;

	[Token(Token = "0x4008CEF")]
	[FieldOffset(Offset = "0x1C")]
	public uint grenade_use_count;

	[Token(Token = "0x4008CF0")]
	[FieldOffset(Offset = "0x20")]
	public uint ice_wall_use_count;

	[Token(Token = "0x4008CF1")]
	[FieldOffset(Offset = "0x24")]
	public uint survival_time;

	[Token(Token = "0x4008CF2")]
	[FieldOffset(Offset = "0x28")]
	public uint help_teammates_count;

	[Token(Token = "0x4008CF3")]
	[FieldOffset(Offset = "0x2C")]
	public uint match_count;

	[Token(Token = "0x6007AED")]
	[Address(RVA = "0x309E4B4", Offset = "0x309E4B4", VA = "0x309E4B4")]
	public CustomRoomPlayerStats()
	{
	}
}
