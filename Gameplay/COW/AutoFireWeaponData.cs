using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005A8")]
public class AutoFireWeaponData : MonoBehaviour
{
	[Token(Token = "0x4004365")]
	[FieldOffset(Offset = "0xC")]
	public string ModelResID;

	[Token(Token = "0x4004366")]
	[FieldOffset(Offset = "0x10")]
	public string FireEffectResID;

	[Token(Token = "0x4004367")]
	[FieldOffset(Offset = "0x14")]
	public string GunTraceResID;

	[Token(Token = "0x4004368")]
	[FieldOffset(Offset = "0x18")]
	public Transform ModelContainer;

	[Token(Token = "0x4004369")]
	[FieldOffset(Offset = "0x1C")]
	public int Damage;

	[Token(Token = "0x400436A")]
	[FieldOffset(Offset = "0x20")]
	public int GroupId;

	[Token(Token = "0x6002270")]
	[Address(RVA = "0x14D2478", Offset = "0x14D2478", VA = "0x14D2478")]
	public AutoFireWeaponData()
	{
	}
}
