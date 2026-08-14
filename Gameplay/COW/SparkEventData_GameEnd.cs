using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E0C")]
internal class SparkEventData_GameEnd : SparkEventData_Base
{
	[Token(Token = "0x400BE49")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400BE4A")]
	[FieldOffset(Offset = "0x14")]
	public bool is_winner;

	[Token(Token = "0x6008FBA")]
	[Address(RVA = "0x20F55E0", Offset = "0x20F55E0", VA = "0x20F55E0")]
	public SparkEventData_GameEnd()
	{
	}

	[Token(Token = "0x6008FBB")]
	[Address(RVA = "0x20F55E8", Offset = "0x20F55E8", VA = "0x20F55E8", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
