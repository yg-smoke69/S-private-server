using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002992")]
public class ManualWeaponItemInfo
{
	[Token(Token = "0x400FFEA")]
	[FieldOffset(Offset = "0x8")]
	public int m_Location;

	[Token(Token = "0x400FFEB")]
	[FieldOffset(Offset = "0xC")]
	public bool Sprite;

	[Token(Token = "0x6010B17")]
	[Address(RVA = "0x1533D10", Offset = "0x1533D10", VA = "0x1533D10")]
	public ManualWeaponItemInfo()
	{
	}
}
