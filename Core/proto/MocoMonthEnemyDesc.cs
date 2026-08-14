using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC4")]
public class MocoMonthEnemyDesc
{
	[Token(Token = "0x400AEBF")]
	[FieldOffset(Offset = "0x8")]
	public uint enemy_id;

	[Token(Token = "0x400AEC0")]
	[FieldOffset(Offset = "0xC")]
	public uint blood_volume;

	[Token(Token = "0x400AEC1")]
	[FieldOffset(Offset = "0x10")]
	public uint score;

	[Token(Token = "0x400AEC2")]
	[FieldOffset(Offset = "0x14")]
	public uint moving_speed;

	[Token(Token = "0x400AEC3")]
	[FieldOffset(Offset = "0x18")]
	public uint moving_direction;

	[Token(Token = "0x400AEC4")]
	[FieldOffset(Offset = "0x1C")]
	public uint moving_limit_grids;

	[Token(Token = "0x600821F")]
	[Address(RVA = "0x30A8AD0", Offset = "0x30A8AD0", VA = "0x30A8AD0")]
	public MocoMonthEnemyDesc()
	{
	}
}
