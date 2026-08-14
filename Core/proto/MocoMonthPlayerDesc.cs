using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC5")]
public class MocoMonthPlayerDesc
{
	[Token(Token = "0x400AEC5")]
	[FieldOffset(Offset = "0x8")]
	public uint player_moving_speed;

	[Token(Token = "0x400AEC6")]
	[FieldOffset(Offset = "0xC")]
	public float bullet_firing_frequency;

	[Token(Token = "0x400AEC7")]
	[FieldOffset(Offset = "0x10")]
	public uint bullet_speed;

	[Token(Token = "0x400AEC8")]
	[FieldOffset(Offset = "0x14")]
	public uint turn_rate;

	[Token(Token = "0x6008220")]
	[Address(RVA = "0x30A8C50", Offset = "0x30A8C50", VA = "0x30A8C50")]
	public MocoMonthPlayerDesc()
	{
	}
}
