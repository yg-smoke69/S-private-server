using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B46")]
public class WeaponSkinOpenTimeDesc
{
	[Token(Token = "0x400AB9D")]
	[FieldOffset(Offset = "0x8")]
	public uint weapon_set;

	[Token(Token = "0x400AB9E")]
	[FieldOffset(Offset = "0xC")]
	public string open_time;

	[Token(Token = "0x400AB9F")]
	[FieldOffset(Offset = "0x10")]
	public long open_time_stamp;

	[Token(Token = "0x400ABA0")]
	[FieldOffset(Offset = "0x18")]
	public bool is_open;

	[Token(Token = "0x60081A1")]
	[Address(RVA = "0x33E5150", Offset = "0x33E5150", VA = "0x33E5150")]
	public WeaponSkinOpenTimeDesc()
	{
	}
}
