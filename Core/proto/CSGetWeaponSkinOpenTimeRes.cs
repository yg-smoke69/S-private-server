using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017FE")]
public class CSGetWeaponSkinOpenTimeRes
{
	[Token(Token = "0x4009BDA")]
	[FieldOffset(Offset = "0x8")]
	public List<WeaponSkinOpenTimeDesc> weapon_skin_open_time_desc;

	[Token(Token = "0x6007E58")]
	[Address(RVA = "0x30965D0", Offset = "0x30965D0", VA = "0x30965D0")]
	public CSGetWeaponSkinOpenTimeRes()
	{
	}
}
