using System;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200092F")]
internal class ZombieTankAnimComponentInfo
{
	[Token(Token = "0x4005543")]
	[FieldOffset(Offset = "0x8")]
	public KPCKLGPOAOD ShieldStatus;

	[Token(Token = "0x4005544")]
	[FieldOffset(Offset = "0xC")]
	public NetworkAIPawnAnimComponent AnimComponent;

	[Token(Token = "0x6004078")]
	[Address(RVA = "0x26F7198", Offset = "0x26F7198", VA = "0x26F7198")]
	public ZombieTankAnimComponentInfo()
	{
	}
}
