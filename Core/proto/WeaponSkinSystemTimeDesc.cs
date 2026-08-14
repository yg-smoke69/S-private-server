using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B45")]
public class WeaponSkinSystemTimeDesc
{
	[Token(Token = "0x400AB9A")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AB9B")]
	[FieldOffset(Offset = "0xC")]
	public string open_time;

	[Token(Token = "0x400AB9C")]
	[FieldOffset(Offset = "0x10")]
	public long open_time_stamp;

	[Token(Token = "0x60081A0")]
	[Address(RVA = "0x33E51F0", Offset = "0x33E51F0", VA = "0x33E51F0")]
	public WeaponSkinSystemTimeDesc()
	{
	}
}
