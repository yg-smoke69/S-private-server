using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028B6")]
public class UIHudWeaponShield : MonoBehaviour
{
	[Token(Token = "0x400FA98")]
	[FieldOffset(Offset = "0xC")]
	public UISprite shieldIcon;

	[Token(Token = "0x400FA99")]
	[FieldOffset(Offset = "0x10")]
	public UISprite hp;

	[Token(Token = "0x601003D")]
	[Address(RVA = "0x255F024", Offset = "0x255F024", VA = "0x255F024")]
	public UIHudWeaponShield()
	{
	}

	[Token(Token = "0x601003E")]
	[Address(RVA = "0x255F02C", Offset = "0x255F02C", VA = "0x255F02C")]
	public void UpdateShieldState(object shield)
	{
	}
}
