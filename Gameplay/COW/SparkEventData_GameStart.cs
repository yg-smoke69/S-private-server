using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E0B")]
internal class SparkEventData_GameStart : SparkEventData_Base
{
	[Token(Token = "0x400BE45")]
	[FieldOffset(Offset = "0x10")]
	public uint group_mode;

	[Token(Token = "0x400BE46")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x400BE47")]
	[FieldOffset(Offset = "0x18")]
	public uint match_mode;

	[Token(Token = "0x400BE48")]
	[FieldOffset(Offset = "0x1C")]
	public uint map_id;

	[Token(Token = "0x6008FB8")]
	[Address(RVA = "0x20F568C", Offset = "0x20F568C", VA = "0x20F568C")]
	public SparkEventData_GameStart()
	{
	}

	[Token(Token = "0x6008FB9")]
	[Address(RVA = "0x20F5694", Offset = "0x20F5694", VA = "0x20F5694", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
