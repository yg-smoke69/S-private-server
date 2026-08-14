using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A3C")]
public class MMRTCParam
{
	[Token(Token = "0x400A447")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A448")]
	[FieldOffset(Offset = "0xC")]
	public float max_point;

	[Token(Token = "0x400A449")]
	[FieldOffset(Offset = "0x10")]
	public float except_game_round;

	[Token(Token = "0x400A44A")]
	[FieldOffset(Offset = "0x14")]
	public float except_damage;

	[Token(Token = "0x400A44B")]
	[FieldOffset(Offset = "0x18")]
	public float result_ratio;

	[Token(Token = "0x400A44C")]
	[FieldOffset(Offset = "0x1C")]
	public float game_round_ratio;

	[Token(Token = "0x400A44D")]
	[FieldOffset(Offset = "0x20")]
	public float damage_ratio;

	[Token(Token = "0x400A44E")]
	[FieldOffset(Offset = "0x24")]
	public uint game_mode;

	[Token(Token = "0x400A44F")]
	[FieldOffset(Offset = "0x28")]
	public float except_game_point;

	[Token(Token = "0x400A450")]
	[FieldOffset(Offset = "0x2C")]
	public float game_point_ratio;

	[Token(Token = "0x6008094")]
	[Address(RVA = "0x30A7140", Offset = "0x30A7140", VA = "0x30A7140")]
	public MMRTCParam()
	{
	}
}
