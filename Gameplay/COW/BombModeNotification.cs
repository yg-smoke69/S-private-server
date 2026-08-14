using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026F1")]
internal class BombModeNotification
{
	[Token(Token = "0x400F074")]
	[FieldOffset(Offset = "0x8")]
	public string BombActionZoneName;

	[Token(Token = "0x400F075")]
	[FieldOffset(Offset = "0xC")]
	public string BombActionZoneNameColor;

	[Token(Token = "0x400F076")]
	[FieldOffset(Offset = "0x10")]
	public string BattleInfo;

	[Token(Token = "0x400F077")]
	[FieldOffset(Offset = "0x14")]
	public string iconName;

	[Token(Token = "0x400F078")]
	[FieldOffset(Offset = "0x18")]
	public Color iconTintColor;

	[Token(Token = "0x600EC2F")]
	[Address(RVA = "0x180D1A8", Offset = "0x180D1A8", VA = "0x180D1A8")]
	public BombModeNotification()
	{
	}
}
