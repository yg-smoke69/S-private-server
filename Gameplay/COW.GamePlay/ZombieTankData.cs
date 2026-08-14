using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000930")]
internal class ZombieTankData : MonoBehaviour
{
	[Token(Token = "0x4005545")]
	[FieldOffset(Offset = "0xC")]
	public GameObject ShieldObj;

	[Token(Token = "0x4005546")]
	[FieldOffset(Offset = "0x10")]
	public List<ZombieTankAnimComponentInfo> ExtraAnimComponents;

	[Token(Token = "0x6004079")]
	[Address(RVA = "0x26F71A0", Offset = "0x26F71A0", VA = "0x26F71A0")]
	public ZombieTankData()
	{
	}

	[Token(Token = "0x600407A")]
	[Address(RVA = "0x26F71A8", Offset = "0x26F71A8", VA = "0x26F71A8")]
	public NetworkAIPawnAnimComponent GetAnimComponent(KPCKLGPOAOD HFBHHDFFJJN)
	{
		return null;
	}
}
