using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E10")]
internal class SparkEventData_DamageTaken : SparkEventData_Base
{
	[Token(Token = "0x400BE4F")]
	[FieldOffset(Offset = "0x10")]
	public ulong from_account_id;

	[Token(Token = "0x400BE50")]
	[FieldOffset(Offset = "0x18")]
	public int damage_taken;

	[Token(Token = "0x400BE51")]
	[FieldOffset(Offset = "0x1C")]
	public int remaining_hp;

	[Token(Token = "0x400BE52")]
	[FieldOffset(Offset = "0x20")]
	public int weapon_id;

	[Token(Token = "0x6008FC2")]
	[Address(RVA = "0x20F5284", Offset = "0x20F5284", VA = "0x20F5284")]
	public SparkEventData_DamageTaken()
	{
	}

	[Token(Token = "0x6008FC3")]
	[Address(RVA = "0x20F528C", Offset = "0x20F528C", VA = "0x20F528C", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
