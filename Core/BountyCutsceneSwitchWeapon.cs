using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B06")]
public class BountyCutsceneSwitchWeapon : MonoBehaviour
{
	[Token(Token = "0x4005F59")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_WeaponOnHand;

	[Token(Token = "0x4005F5A")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_WeaponOnBack;

	[Token(Token = "0x4005F5B")]
	[FieldOffset(Offset = "0x14")]
	private Transform HandSlot;

	[Token(Token = "0x4005F5C")]
	[FieldOffset(Offset = "0x18")]
	private Transform BackSlot;

	[Token(Token = "0x4005F5D")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_IsInited;

	[Token(Token = "0x60054C0")]
	[Address(RVA = "0x2ED5718", Offset = "0x2ED5718", VA = "0x2ED5718")]
	public BountyCutsceneSwitchWeapon()
	{
	}

	[Token(Token = "0x60054C1")]
	[Address(RVA = "0x2ED5720", Offset = "0x2ED5720", VA = "0x2ED5720")]
	public void InitSlot()
	{
	}

	[Token(Token = "0x60054C2")]
	[Address(RVA = "0x2ED57B8", Offset = "0x2ED57B8", VA = "0x2ED57B8")]
	public Transform FindTransformByName(string name)
	{
		return null;
	}

	[Token(Token = "0x60054C3")]
	[Address(RVA = "0x2ED59D4", Offset = "0x2ED59D4", VA = "0x2ED59D4")]
	public void ShowWeaponOnHand(int isShow)
	{
	}

	[Token(Token = "0x60054C4")]
	[Address(RVA = "0x2ED5D58", Offset = "0x2ED5D58", VA = "0x2ED5D58")]
	public void ShowWeaponOnBack(int isShow)
	{
	}

	[Token(Token = "0x60054C5")]
	[Address(RVA = "0x2ED59E0", Offset = "0x2ED59E0", VA = "0x2ED59E0")]
	public void ShowWeaponOnHand(bool isShow)
	{
	}

	[Token(Token = "0x60054C6")]
	[Address(RVA = "0x2ED5D64", Offset = "0x2ED5D64", VA = "0x2ED5D64")]
	public void ShowWeaponOnBack(bool isShow)
	{
	}
}
