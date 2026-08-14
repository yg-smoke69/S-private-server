using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E11")]
internal class SparkEventData_Kill : SparkEventData_Base
{
	[Token(Token = "0x400BE53")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x400BE54")]
	[FieldOffset(Offset = "0x18")]
	public int weapon_id;

	[Token(Token = "0x400BE55")]
	[FieldOffset(Offset = "0x1C")]
	public int kill_count;

	[Token(Token = "0x6008FC4")]
	[Address(RVA = "0x20F5738", Offset = "0x20F5738", VA = "0x20F5738")]
	public SparkEventData_Kill()
	{
	}

	[Token(Token = "0x6008FC5")]
	[Address(RVA = "0x20F5740", Offset = "0x20F5740", VA = "0x20F5740", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
