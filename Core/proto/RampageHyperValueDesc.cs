using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C14")]
public class RampageHyperValueDesc
{
	[Token(Token = "0x400B0B1")]
	[FieldOffset(Offset = "0x8")]
	public uint br_hyper_value_base;

	[Token(Token = "0x400B0B2")]
	[FieldOffset(Offset = "0xC")]
	public uint cs_hyper_value_base;

	[Token(Token = "0x400B0B3")]
	[FieldOffset(Offset = "0x10")]
	public uint rampage4_hyper_value_base;

	[Token(Token = "0x400B0B4")]
	[FieldOffset(Offset = "0x14")]
	public uint hyper_value_per_kill;

	[Token(Token = "0x400B0B5")]
	[FieldOffset(Offset = "0x18")]
	public uint max_hyper_value_kill;

	[Token(Token = "0x400B0B6")]
	[FieldOffset(Offset = "0x1C")]
	public uint hyper_value_per_assist;

	[Token(Token = "0x400B0B7")]
	[FieldOffset(Offset = "0x20")]
	public uint max_hyper_value_assist;

	[Token(Token = "0x400B0B8")]
	[FieldOffset(Offset = "0x24")]
	public uint hyper_value_per_damage;

	[Token(Token = "0x400B0B9")]
	[FieldOffset(Offset = "0x28")]
	public uint max_hyper_value_damage;

	[Token(Token = "0x400B0BA")]
	[FieldOffset(Offset = "0x2C")]
	public uint hyper_value_per_distance;

	[Token(Token = "0x400B0BB")]
	[FieldOffset(Offset = "0x30")]
	public uint max_hyper_value_distance;

	[Token(Token = "0x400B0BC")]
	[FieldOffset(Offset = "0x34")]
	public uint hyper_value_per_medkit;

	[Token(Token = "0x400B0BD")]
	[FieldOffset(Offset = "0x38")]
	public uint max_hyper_value_medkit;

	[Token(Token = "0x400B0BE")]
	[FieldOffset(Offset = "0x3C")]
	public uint hyper_value_per_survival_min;

	[Token(Token = "0x400B0BF")]
	[FieldOffset(Offset = "0x40")]
	public uint max_hyper_value_survival_min;

	[Token(Token = "0x600826E")]
	[Address(RVA = "0x33E0550", Offset = "0x33E0550", VA = "0x33E0550")]
	public RampageHyperValueDesc()
	{
	}
}
