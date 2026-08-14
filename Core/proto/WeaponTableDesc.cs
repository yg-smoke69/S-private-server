using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6F")]
public class WeaponTableDesc
{
	[Token(Token = "0x400A57F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A580")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x60080CC")]
	[Address(RVA = "0x33E5330", Offset = "0x33E5330", VA = "0x33E5330")]
	public WeaponTableDesc()
	{
	}
}
