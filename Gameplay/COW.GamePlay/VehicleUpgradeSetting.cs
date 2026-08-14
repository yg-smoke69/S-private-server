using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x20004CB")]
public class VehicleUpgradeSetting
{
	[Token(Token = "0x4004001")]
	[FieldOffset(Offset = "0x8")]
	public GameObject Model;

	[Token(Token = "0x4004002")]
	[FieldOffset(Offset = "0xC")]
	public Transform EffectAnchor;

	[Token(Token = "0x4004003")]
	[FieldOffset(Offset = "0x10")]
	public string EffectResID;

	[Token(Token = "0x4004004")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID ResID;

	[Token(Token = "0x4004005")]
	[FieldOffset(Offset = "0x18")]
	public string SoundResID;

	[Token(Token = "0x4004006")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID SoundRes;

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x26F34E8", Offset = "0x26F34E8", VA = "0x26F34E8")]
	public VehicleUpgradeSetting()
	{
	}
}
