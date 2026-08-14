using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E0F")]
internal class SparkEventData_DamageEnemy : SparkEventData_Base
{
	[Token(Token = "0x400BE4B")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x400BE4C")]
	[FieldOffset(Offset = "0x18")]
	public int damage_dealt;

	[Token(Token = "0x400BE4D")]
	[FieldOffset(Offset = "0x1C")]
	public int weapon_id;

	[Token(Token = "0x400BE4E")]
	[FieldOffset(Offset = "0x20")]
	public bool hit_head;

	[Token(Token = "0x6008FC0")]
	[Address(RVA = "0x20F51D8", Offset = "0x20F51D8", VA = "0x20F51D8")]
	public SparkEventData_DamageEnemy()
	{
	}

	[Token(Token = "0x6008FC1")]
	[Address(RVA = "0x20F51E0", Offset = "0x20F51E0", VA = "0x20F51E0", Slot = "4")]
	public override string GetEventType()
	{
		return null;
	}
}
