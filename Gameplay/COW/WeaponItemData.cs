using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200294A")]
public class WeaponItemData
{
	[Token(Token = "0x400FE77")]
	[FieldOffset(Offset = "0x8")]
	public WeaponSkinBaseInfo Info;

	[Token(Token = "0x400FE78")]
	[FieldOffset(Offset = "0xC")]
	public bool IsEquipped;

	[Token(Token = "0x400FE79")]
	[FieldOffset(Offset = "0xD")]
	public bool IsNewGet;

	[Token(Token = "0x60107E2")]
	[Address(RVA = "0x21A408C", Offset = "0x21A408C", VA = "0x21A408C")]
	public WeaponItemData()
	{
	}

	[Token(Token = "0x60107E3")]
	[Address(RVA = "0x21A4094", Offset = "0x21A4094", VA = "0x21A4094")]
	public int CompareTo(WeaponItemData other)
	{
		return default(int);
	}
}
